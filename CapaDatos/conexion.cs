using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class conexion
    {
        // Cadena de conexión dinámica que lee desde archivo externo o configuración
        private static string _cn = null;

        public static string cn
        {
            get
            {
                if (_cn == null)
                {
                    _cn = ConfiguracionDB.ObtenerCadenaConexion();
                }
                return _cn;
            }
            set
            {
                _cn = value;
            }
        }

        /// <summary>
        /// Fuerza la recarga de la cadena de conexión
        /// </summary>
        public static void RecargarConexion()
        {
            _cn = null;
        }
    }
}
