using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmConfiguracionDB : Form
    {
        public frmConfiguracionDB()
        {
            InitializeComponent();
            CargarConfiguracionActual();
            CargarEjemplos();
        }

        private void CargarConfiguracionActual()
        {
            txtCadenaConexion.Text = ConfiguracionDB.ObtenerCadenaConexion();
        }

        private void CargarEjemplos()
        {
            var ejemplos = ConfiguracionDB.ObtenerEjemplosConexion();
            cboEjemplos.Items.Clear();
            cboEjemplos.Items.Add("-- Selecciona un ejemplo --");
            foreach (var ejemplo in ejemplos)
            {
                cboEjemplos.Items.Add(ejemplo);
            }
            cboEjemplos.SelectedIndex = 0;
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            string cadena = ObtenerCadenaSanitizada();

            if (string.IsNullOrWhiteSpace(cadena))
            {
                MessageBox.Show("Por favor, ingresa una cadena de conexión.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnProbarConexion.Enabled = false;
            lblEstado.Text = "Probando conexión...";
            lblEstado.ForeColor = System.Drawing.Color.Blue;

            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    lblEstado.Text = "✓ Conexión exitosa";
                    lblEstado.ForeColor = System.Drawing.Color.Green;
                    MessageBox.Show("Conexión exitosa con la base de datos.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                lblEstado.Text = "✗ Error de conexión";
                lblEstado.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show(string.Format("Error al conectar:\n\n{0}", ex.Message), "Error de Conexión", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnProbarConexion.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cadena = ObtenerCadenaSanitizada();

            if (string.IsNullOrWhiteSpace(cadena))
            {
                MessageBox.Show("Por favor, ingresa una cadena de conexión.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ConfiguracionDB.GuardarCadenaConexion(cadena))
            {
                MessageBox.Show("Configuración guardada correctamente.\n\nLa nueva conexión se usará al reiniciar la aplicación.", 
                    "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar la configuración.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cboEjemplos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEjemplos.SelectedIndex > 0)
            {
                txtCadenaConexion.Text = cboEjemplos.SelectedItem.ToString();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string ayuda = @"GUÍA DE CONFIGURACIÓN DE CONEXIÓN

1. SERVIDOR LOCAL:
   Data Source=localhost\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true

2. SERVIDOR POR NOMBRE DE EQUIPO:
   Data Source=NOMBRE_PC\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true

3. SERVIDOR POR IP (Red Local):
   Data Source=192.168.1.100\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true

4. CON USUARIO Y CONTRASEÑA:
   Data Source=servidor\SQLEXPRESS;Initial Catalog=DBSisSara;User ID=usuario;Password=pass;Integrated Security=false

PARTES DE LA CADENA:
• Data Source: Servidor SQL (IP, nombre PC, o localhost)
• Initial Catalog: Nombre de la base de datos
• Integrated Security=true: Usa autenticación de Windows
• User ID y Password: Para autenticación SQL Server

TIPS:
✓ Para red dinámica, usa 'localhost' o nombre del equipo
✓ Para IP fija, usa la dirección IP del servidor
✓ Prueba la conexión antes de guardar";

            MessageBox.Show(ayuda, "Ayuda de Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Devuelve la primera línea válida (sin espacios ni comentarios) para evitar guardar cadenas con espacios iniciales/finales
        private string ObtenerCadenaSanitizada()
        {
            foreach (var raw in txtCadenaConexion.Lines)
            {
                var trimmed = (raw ?? string.Empty).Trim();
                if (string.IsNullOrEmpty(trimmed)) continue;
                if (trimmed.StartsWith("REM", StringComparison.OrdinalIgnoreCase)) continue;
                return trimmed;
            }

            // Si no hay líneas múltiples, usar todo el texto trimmeado
            return (txtCadenaConexion.Text ?? string.Empty).Trim();
        }
    }
}
