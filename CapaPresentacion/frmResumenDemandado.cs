using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    /// <summary>
    /// Ventana de solo lectura que resume los datos del demandado y lista todos sus domicilios.
    /// Diseñada para soportar muchos registros con un grid de ancho completo y scroll vertical.
    /// </summary>
    public class frmResumenDemandado : Form
    {
        private readonly Label lblNombre;
        private readonly Label lblRut;
        private readonly Label lblRepresentante;
        private readonly Label lblDomicilios;
        private readonly DataGridView dgwDomicilios;
        private readonly TableLayoutPanel layout;

        public frmResumenDemandado(int demandadoId, string nombre, string rut, string representante, DataTable domicilios)
        {
            Text = "Resumen del Demandado";
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(720, 480);
            Size = new Size(900, 600);

            layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                AutoSize = true,
            };

            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            lblNombre = new Label { AutoSize = true, Font = new Font(Font, FontStyle.Bold), Text = "Nombre: " + nombre };
            lblRut = new Label { AutoSize = true, Text = string.IsNullOrWhiteSpace(rut) ? "Rut: (sin dato)" : "Rut: " + rut };
            lblRepresentante = new Label { AutoSize = true, Text = string.IsNullOrWhiteSpace(representante) ? "Representante: (sin dato)" : "Representante: " + representante };

            int totalDomicilios = 0;
            if (domicilios != null)
            {
                totalDomicilios = domicilios.Rows.Count;
            }
            lblDomicilios = new Label { AutoSize = true, Font = new Font(Font, FontStyle.Bold), Text = string.Format("Domicilios ({0})", totalDomicilios) };

            dgwDomicilios = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToOrderColumns = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells,
                RowHeadersVisible = false,
                DataSource = domicilios,
            };

            layout.Controls.Add(lblNombre, 0, 0);
            layout.Controls.Add(lblRut, 0, 1);
            layout.Controls.Add(lblRepresentante, 0, 2);
            layout.Controls.Add(lblDomicilios, 0, 3);
            layout.Controls.Add(dgwDomicilios, 0, 4);

            Controls.Add(layout);

            // Ajustar cabeceras si la tabla viene con columnas conocidas
            ConfigureGridHeaders();
        }

        private void ConfigureGridHeaders()
        {
            if (dgwDomicilios == null || dgwDomicilios.Columns == null) return;

            if (dgwDomicilios.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "direcc"))
            {
                dgwDomicilios.Columns["direcc"].HeaderText = "Domicilio";
            }

            if (dgwDomicilios.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "razon"))
            {
                dgwDomicilios.Columns["razon"].HeaderText = "Diligencia";
            }

            if (dgwDomicilios.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "id_domicilio"))
            {
                dgwDomicilios.Columns["id_domicilio"].Visible = false;
            }

            if (dgwDomicilios.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "fk_id_demandado"))
            {
                dgwDomicilios.Columns["fk_id_demandado"].Visible = false;
            }
        }
    }
}
