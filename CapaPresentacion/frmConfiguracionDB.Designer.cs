namespace CapaPresentacion
{
    partial class frmConfiguracionDB
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCadena = new System.Windows.Forms.Label();
            this.txtCadenaConexion = new System.Windows.Forms.TextBox();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpEjemplos = new System.Windows.Forms.GroupBox();
            this.cboEjemplos = new System.Windows.Forms.ComboBox();
            this.lblEjemplos = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.grpEjemplos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configuración de Base de Datos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(13, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(559, 32);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Configure la conexión a la base de datos SQL Server. Esta configuración se guarda" +
    "rá en un archivo externo y puede ser modificada sin recompilar la aplicación.";
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(13, 175);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(107, 13);
            this.lblCadena.TabIndex = 2;
            this.lblCadena.Text = "Cadena de conexión:";
            // 
            // txtCadenaConexion
            // 
            this.txtCadenaConexion.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtCadenaConexion.Location = new System.Drawing.Point(16, 191);
            this.txtCadenaConexion.Multiline = true;
            this.txtCadenaConexion.Name = "txtCadenaConexion";
            this.txtCadenaConexion.Size = new System.Drawing.Size(556, 60);
            this.txtCadenaConexion.TabIndex = 3;
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(16, 257);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(120, 30);
            this.btnProbarConexion.TabIndex = 4;
            this.btnProbarConexion.Text = "Probar Conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(376, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(482, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(142, 265);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 7;
            // 
            // grpEjemplos
            // 
            this.grpEjemplos.Controls.Add(this.cboEjemplos);
            this.grpEjemplos.Controls.Add(this.lblEjemplos);
            this.grpEjemplos.Location = new System.Drawing.Point(16, 73);
            this.grpEjemplos.Name = "grpEjemplos";
            this.grpEjemplos.Size = new System.Drawing.Size(556, 85);
            this.grpEjemplos.TabIndex = 8;
            this.grpEjemplos.TabStop = false;
            this.grpEjemplos.Text = "Ejemplos de Configuración";
            // 
            // cboEjemplos
            // 
            this.cboEjemplos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEjemplos.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.cboEjemplos.FormattingEnabled = true;
            this.cboEjemplos.Location = new System.Drawing.Point(6, 45);
            this.cboEjemplos.Name = "cboEjemplos";
            this.cboEjemplos.Size = new System.Drawing.Size(544, 21);
            this.cboEjemplos.TabIndex = 1;
            this.cboEjemplos.SelectedIndexChanged += new System.EventHandler(this.cboEjemplos_SelectedIndexChanged);
            // 
            // lblEjemplos
            // 
            this.lblEjemplos.AutoSize = true;
            this.lblEjemplos.Location = new System.Drawing.Point(6, 25);
            this.lblEjemplos.Name = "lblEjemplos";
            this.lblEjemplos.Size = new System.Drawing.Size(283, 13);
            this.lblEjemplos.TabIndex = 0;
            this.lblEjemplos.Text = "Selecciona un ejemplo para copiar en la cadena de conexión:";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(16, 320);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 30);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "? Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmConfiguracionDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.grpEjemplos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.txtCadenaConexion);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracionDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Base de Datos";
            this.grpEjemplos.ResumeLayout(false);
            this.grpEjemplos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.TextBox txtCadenaConexion;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpEjemplos;
        private System.Windows.Forms.ComboBox cboEjemplos;
        private System.Windows.Forms.Label lblEjemplos;
        private System.Windows.Forms.Button btnAyuda;
    }
}
