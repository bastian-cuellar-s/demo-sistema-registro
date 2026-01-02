using System;
using System.Configuration;
using System.IO;

namespace CapaDatos
{
    public class ConfiguracionDB
    {
        private static string archivoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "conexion.config");

        /// <summary>
        /// Obtiene la cadena de conexión desde archivo externo o App.config
        /// </summary>
        public static string ObtenerCadenaConexion()
        {
            // Prioridad 1: Archivo externo conexion.config (para fácil edición)
            if (File.Exists(archivoConfig))
            {
                try
                {
                    // Tomar la primera línea no vacía ni comentada (evita que los REM rompan la cadena)
                    foreach (var line in File.ReadAllLines(archivoConfig))
                    {
                        string trimmed = line.Trim();
                        if (string.IsNullOrEmpty(trimmed)) continue;
                        if (trimmed.StartsWith("REM", StringComparison.OrdinalIgnoreCase)) continue;
                        return trimmed;
                    }
                }
                catch (Exception ex)
                {
                    // Si hay error leyendo el archivo, usar configuración por defecto
                    System.Diagnostics.Debug.WriteLine("Error leyendo conexion.config: " + ex.Message);
                }
            }

            // Prioridad 2: App.config
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["CapaDatos.Properties.Settings.cn"];
                if (connectionString != null && !string.IsNullOrEmpty(connectionString.ConnectionString))
                {
                    return connectionString.ConnectionString;
                }
            }
            catch { }

            // Prioridad 3: Intentar con servidor local por defecto
            string servidorLocal = ObtenerServidorLocal();
            return string.Format("Data Source={0};Initial Catalog=DBSisSara;Integrated Security=true", servidorLocal);
        }

        /// <summary>
        /// Guarda la cadena de conexión en el archivo externo
        /// </summary>
        public static bool GuardarCadenaConexion(string cadenaConexion)
        {
            try
            {
                File.WriteAllText(archivoConfig, cadenaConexion);
                // Actualizar la variable estática de conexión
                conexion.cn = cadenaConexion;
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error guardando conexion.config: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Intenta detectar el servidor SQL local automáticamente
        /// </summary>
        public static string ObtenerServidorLocal()
        {
            // Opción 1: Localhost
            string[] opciones = new string[]
            {
                "localhost\\SQLEXPRESS",
                ".\\SQLEXPRESS",
                "(local)\\SQLEXPRESS",
                Environment.MachineName + "\\SQLEXPRESS",
                "localhost",
                "."
            };

            return opciones[0]; // Retorna la primera opción por defecto
        }

        /// <summary>
        /// Verifica si existe el archivo de configuración externa
        /// </summary>
        public static bool ExisteConfiguracionExterna()
        {
            return File.Exists(archivoConfig);
        }

        /// <summary>
        /// Crea un archivo de configuración de ejemplo
        /// </summary>
        public static void CrearConfiguracionEjemplo()
        {
            if (!File.Exists(archivoConfig))
            {
                string ejemplo = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true

REM Instrucciones para configurar la conexión:
REM 1. Reemplaza 'localhost\SQLEXPRESS' con tu servidor SQL
REM 2. Si usas IP, usa: Data Source=192.168.1.100\SQLEXPRESS;...
REM 3. Para autenticación SQL: ...;User ID=usuario;Password=contraseña;Integrated Security=false
REM 4. Solo la primera línea se usa como cadena de conexión
";
                File.WriteAllText(archivoConfig, ejemplo);
            }
        }

        /// <summary>
        /// Genera diferentes ejemplos de cadenas de conexión
        /// </summary>
        public static string[] ObtenerEjemplosConexion()
        {
            string servidor = Environment.MachineName;
            return new string[]
            {
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true",
                string.Format("Data Source={0}\\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true", servidor),
                "Data Source=.\\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true",
                "Data Source=192.168.1.100\\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true",
                "Data Source=192.168.1.100\\SQLEXPRESS;Initial Catalog=DBSisSara;User ID=sa;Password=tu_contraseña;Integrated Security=false"
            };
        }
    }
}
