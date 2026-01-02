namespace CapaPresentacion
{
    partial class frmDemandado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConfiguracionDB = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbBuscartt = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgwListado = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbTPersona = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblrepresent = new System.Windows.Forms.Label();
            this.txtRepresent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBuscarDo = new System.Windows.Forms.ComboBox();
            this.chkEliminarDo = new System.Windows.Forms.CheckBox();
            this.btnBuscarDo = new System.Windows.Forms.Button();
            this.txtBuscarDo = new System.Windows.Forms.TextBox();
            this.lblContDo = new System.Windows.Forms.Label();
            this.cbBuscarDe = new System.Windows.Forms.ComboBox();
            this.chkEliminarDe = new System.Windows.Forms.CheckBox();
            this.btnBuscarDe = new System.Windows.Forms.Button();
            this.txtBuscarDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoDo = new System.Windows.Forms.Button();
            this.txtIdDomicilio = new System.Windows.Forms.TextBox();
            this.btnCancelarDo = new System.Windows.Forms.Button();
            this.btnEliminarDo = new System.Windows.Forms.Button();
            this.btnEditarDo = new System.Windows.Forms.Button();
            this.btnGuardarDo = new System.Windows.Forms.Button();
            this.btnNuevoDe = new System.Windows.Forms.Button();
            this.txtIdDemandado = new System.Windows.Forms.TextBox();
            this.lblContDe = new System.Windows.Forms.Label();
            this.btnCancelarDe = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEliminarDe = new System.Windows.Forms.Button();
            this.btnEditarDe = new System.Windows.Forms.Button();
            this.dgwDomicilio = new System.Windows.Forms.DataGridView();
            this.EliminarDo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtDirecc = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardarDe = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgwDemandado = new System.Windows.Forms.DataGridView();
            this.EliminarDe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDemandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 727);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConfiguracionDB);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cbBuscartt);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dgwListado);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1492, 689);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sistema";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(21, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "Buscar por";
            // 
            // cbBuscartt
            // 
            this.cbBuscartt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscartt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbBuscartt.FormattingEnabled = true;
            this.cbBuscartt.Items.AddRange(new object[] {
            "Nombre",
            "Rut",
            "Domicilio",
            "Razon",
            "Representante"});
            this.cbBuscartt.Location = new System.Drawing.Point(156, 36);
            this.cbBuscartt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBuscartt.Name = "cbBuscartt";
            this.cbBuscartt.Size = new System.Drawing.Size(121, 33);
            this.cbBuscartt.TabIndex = 39;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 81);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 25);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "label11";
            // 
            // btnConfiguracionDB
            // 
            this.btnConfiguracionDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnConfiguracionDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracionDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfiguracionDB.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracionDB.Location = new System.Drawing.Point(1362, 34);
            this.btnConfiguracionDB.Name = "btnConfiguracionDB";
            this.btnConfiguracionDB.Size = new System.Drawing.Size(105, 39);
            this.btnConfiguracionDB.TabIndex = 41;
            this.btnConfiguracionDB.Text = "⚙ Config";
            this.btnConfiguracionDB.UseVisualStyleBackColor = false;
            this.btnConfiguracionDB.Click += new System.EventHandler(this.btnConfiguracionDB_Click);
            // 
            // dgwListado
            // 
            this.dgwListado.AllowUserToAddRows = false;
            this.dgwListado.AllowUserToDeleteRows = false;
            this.dgwListado.AllowUserToOrderColumns = true;
            this.dgwListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListado.Location = new System.Drawing.Point(26, 108);
            this.dgwListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwListado.MultiSelect = false;
            this.dgwListado.Name = "dgwListado";
            this.dgwListado.ReadOnly = true;
            this.dgwListado.RowTemplate.Height = 24;
            this.dgwListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListado.Size = new System.Drawing.Size(1441, 542);
            this.dgwListado.TabIndex = 3;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1236, 34);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(120, 39);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(283, 39);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(947, 30);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.Validating += new System.ComponentModel.CancelEventHandler(this.txtbuscar_Validating);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbTPersona);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lblrepresent);
            this.tabPage2.Controls.Add(this.txtRepresent);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbBuscarDo);
            this.tabPage2.Controls.Add(this.chkEliminarDo);
            this.tabPage2.Controls.Add(this.btnBuscarDo);
            this.tabPage2.Controls.Add(this.txtBuscarDo);
            this.tabPage2.Controls.Add(this.lblContDo);
            this.tabPage2.Controls.Add(this.cbBuscarDe);
            this.tabPage2.Controls.Add(this.chkEliminarDe);
            this.tabPage2.Controls.Add(this.btnBuscarDe);
            this.tabPage2.Controls.Add(this.txtBuscarDe);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnNuevoDo);
            this.tabPage2.Controls.Add(this.txtIdDomicilio);
            this.tabPage2.Controls.Add(this.btnCancelarDo);
            this.tabPage2.Controls.Add(this.btnEliminarDo);
            this.tabPage2.Controls.Add(this.btnEditarDo);
            this.tabPage2.Controls.Add(this.btnGuardarDo);
            this.tabPage2.Controls.Add(this.btnNuevoDe);
            this.tabPage2.Controls.Add(this.txtIdDemandado);
            this.tabPage2.Controls.Add(this.lblContDe);
            this.tabPage2.Controls.Add(this.btnCancelarDe);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnEliminarDe);
            this.tabPage2.Controls.Add(this.btnEditarDe);
            this.tabPage2.Controls.Add(this.dgwDomicilio);
            this.tabPage2.Controls.Add(this.txtDirecc);
            this.tabPage2.Controls.Add(this.txtRazon);
            this.tabPage2.Controls.Add(this.txtRut);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.btnGuardarDe);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgwDemandado);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1492, 689);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbTPersona
            // 
            this.cbTPersona.BackColor = System.Drawing.SystemColors.Window;
            this.cbTPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTPersona.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbTPersona.FormattingEnabled = true;
            this.cbTPersona.Items.AddRange(new object[] {
            "Persona Juridica",
            "Persona Natural"});
            this.cbTPersona.Location = new System.Drawing.Point(370, 82);
            this.cbTPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTPersona.Name = "cbTPersona";
            this.cbTPersona.Size = new System.Drawing.Size(290, 33);
            this.cbTPersona.TabIndex = 48;
            this.cbTPersona.SelectedIndexChanged += new System.EventHandler(this.cbTPersona_SelectedIndexChanged);
            this.cbTPersona.Click += new System.EventHandler(this.cbTPersona_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Seleccione el tipo de persona";
            // 
            // lblrepresent
            // 
            this.lblrepresent.AutoSize = true;
            this.lblrepresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepresent.Location = new System.Drawing.Point(6, 234);
            this.lblrepresent.Name = "lblrepresent";
            this.lblrepresent.Size = new System.Drawing.Size(118, 20);
            this.lblrepresent.TabIndex = 45;
            this.lblrepresent.Text = "Representante";
            // 
            // txtRepresent
            // 
            this.txtRepresent.Location = new System.Drawing.Point(145, 224);
            this.txtRepresent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRepresent.Name = "txtRepresent";
            this.txtRepresent.Size = new System.Drawing.Size(515, 30);
            this.txtRepresent.TabIndex = 44;
            this.txtRepresent.TextChanged += new System.EventHandler(this.txtRepresent_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(625, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 43;
            this.label9.Text = "Buscar por";
            // 
            // cbBuscarDo
            // 
            this.cbBuscarDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarDo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbBuscarDo.FormattingEnabled = true;
            this.cbBuscarDo.Items.AddRange(new object[] {
            "Direccion",
            "Razon"});
            this.cbBuscarDo.Location = new System.Drawing.Point(760, 350);
            this.cbBuscarDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBuscarDo.Name = "cbBuscarDo";
            this.cbBuscarDo.Size = new System.Drawing.Size(121, 33);
            this.cbBuscarDo.TabIndex = 42;
            // 
            // chkEliminarDo
            // 
            this.chkEliminarDo.AutoSize = true;
            this.chkEliminarDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminarDo.Location = new System.Drawing.Point(728, 386);
            this.chkEliminarDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEliminarDo.Name = "chkEliminarDo";
            this.chkEliminarDo.Size = new System.Drawing.Size(80, 21);
            this.chkEliminarDo.TabIndex = 41;
            this.chkEliminarDo.Text = "Eliminar";
            this.chkEliminarDo.UseVisualStyleBackColor = true;
            this.chkEliminarDo.CheckedChanged += new System.EventHandler(this.chkEliminarDo_CheckedChanged);
            // 
            // btnBuscarDo
            // 
            this.btnBuscarDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDo.Location = new System.Drawing.Point(1321, 350);
            this.btnBuscarDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarDo.Name = "btnBuscarDo";
            this.btnBuscarDo.Size = new System.Drawing.Size(120, 39);
            this.btnBuscarDo.TabIndex = 40;
            this.btnBuscarDo.Text = "Buscar";
            this.btnBuscarDo.UseVisualStyleBackColor = true;
            this.btnBuscarDo.Click += new System.EventHandler(this.btnBuscarDo_Click);
            // 
            // txtBuscarDo
            // 
            this.txtBuscarDo.Location = new System.Drawing.Point(887, 353);
            this.txtBuscarDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarDo.Name = "txtBuscarDo";
            this.txtBuscarDo.Size = new System.Drawing.Size(428, 30);
            this.txtBuscarDo.TabIndex = 39;
            this.txtBuscarDo.TextChanged += new System.EventHandler(this.txtBuscarDo_TextChanged);
            // 
            // lblContDo
            // 
            this.lblContDo.AutoSize = true;
            this.lblContDo.Location = new System.Drawing.Point(723, 649);
            this.lblContDo.Name = "lblContDo";
            this.lblContDo.Size = new System.Drawing.Size(75, 25);
            this.lblContDo.TabIndex = 37;
            this.lblContDo.Text = "label11";
            // 
            // cbBuscarDe
            // 
            this.cbBuscarDe.BackColor = System.Drawing.SystemColors.Window;
            this.cbBuscarDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarDe.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbBuscarDe.FormattingEnabled = true;
            this.cbBuscarDe.Items.AddRange(new object[] {
            "Nombre",
            "Rut",
            "Representante"});
            this.cbBuscarDe.Location = new System.Drawing.Point(728, 27);
            this.cbBuscarDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBuscarDe.Name = "cbBuscarDe";
            this.cbBuscarDe.Size = new System.Drawing.Size(153, 33);
            this.cbBuscarDe.TabIndex = 36;
            // 
            // chkEliminarDe
            // 
            this.chkEliminarDe.AutoSize = true;
            this.chkEliminarDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminarDe.Location = new System.Drawing.Point(728, 64);
            this.chkEliminarDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEliminarDe.Name = "chkEliminarDe";
            this.chkEliminarDe.Size = new System.Drawing.Size(80, 21);
            this.chkEliminarDe.TabIndex = 35;
            this.chkEliminarDe.Text = "Eliminar";
            this.chkEliminarDe.UseVisualStyleBackColor = true;
            this.chkEliminarDe.CheckedChanged += new System.EventHandler(this.chkEliminarDe_CheckedChanged_1);
            // 
            // btnBuscarDe
            // 
            this.btnBuscarDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDe.Location = new System.Drawing.Point(1321, 20);
            this.btnBuscarDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarDe.Name = "btnBuscarDe";
            this.btnBuscarDe.Size = new System.Drawing.Size(120, 39);
            this.btnBuscarDe.TabIndex = 33;
            this.btnBuscarDe.Text = "Buscar";
            this.btnBuscarDe.UseVisualStyleBackColor = true;
            this.btnBuscarDe.Click += new System.EventHandler(this.btnBuscarDe_Click);
            // 
            // txtBuscarDe
            // 
            this.txtBuscarDe.Location = new System.Drawing.Point(887, 25);
            this.txtBuscarDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarDe.Name = "txtBuscarDe";
            this.txtBuscarDe.Size = new System.Drawing.Size(428, 30);
            this.txtBuscarDe.TabIndex = 32;
            this.txtBuscarDe.TextChanged += new System.EventHandler(this.txtBuscarDe_TextChanged);
            this.txtBuscarDe.Validating += new System.ComponentModel.CancelEventHandler(this.txtBuscarDe_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(593, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Buscar por";
            // 
            // btnNuevoDo
            // 
            this.btnNuevoDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDo.Location = new System.Drawing.Point(371, 586);
            this.btnNuevoDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoDo.Name = "btnNuevoDo";
            this.btnNuevoDo.Size = new System.Drawing.Size(120, 39);
            this.btnNuevoDo.TabIndex = 30;
            this.btnNuevoDo.Text = "Nuevo";
            this.btnNuevoDo.UseVisualStyleBackColor = true;
            this.btnNuevoDo.Click += new System.EventHandler(this.btnNuevoDo_Click);
            // 
            // txtIdDomicilio
            // 
            this.txtIdDomicilio.Location = new System.Drawing.Point(145, 529);
            this.txtIdDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdDomicilio.Name = "txtIdDomicilio";
            this.txtIdDomicilio.Size = new System.Drawing.Size(80, 30);
            this.txtIdDomicilio.TabIndex = 29;
            this.txtIdDomicilio.Visible = false;
            // 
            // btnCancelarDo
            // 
            this.btnCancelarDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDo.Location = new System.Drawing.Point(540, 586);
            this.btnCancelarDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarDo.Name = "btnCancelarDo";
            this.btnCancelarDo.Size = new System.Drawing.Size(120, 39);
            this.btnCancelarDo.TabIndex = 28;
            this.btnCancelarDo.Text = "Cancelar";
            this.btnCancelarDo.UseVisualStyleBackColor = true;
            this.btnCancelarDo.Click += new System.EventHandler(this.btnCancelarDo_Click);
            // 
            // btnEliminarDo
            // 
            this.btnEliminarDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDo.Location = new System.Drawing.Point(200, 586);
            this.btnEliminarDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarDo.Name = "btnEliminarDo";
            this.btnEliminarDo.Size = new System.Drawing.Size(120, 39);
            this.btnEliminarDo.TabIndex = 27;
            this.btnEliminarDo.Text = "Eliminar";
            this.btnEliminarDo.UseVisualStyleBackColor = true;
            this.btnEliminarDo.Click += new System.EventHandler(this.btnEliminarDo_Click);
            // 
            // btnEditarDo
            // 
            this.btnEditarDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDo.Location = new System.Drawing.Point(29, 587);
            this.btnEditarDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarDo.Name = "btnEditarDo";
            this.btnEditarDo.Size = new System.Drawing.Size(120, 39);
            this.btnEditarDo.TabIndex = 26;
            this.btnEditarDo.Text = "Editar";
            this.btnEditarDo.UseVisualStyleBackColor = true;
            this.btnEditarDo.Click += new System.EventHandler(this.btnEditarDo_Click);
            // 
            // btnGuardarDo
            // 
            this.btnGuardarDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDo.Location = new System.Drawing.Point(29, 586);
            this.btnGuardarDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarDo.Name = "btnGuardarDo";
            this.btnGuardarDo.Size = new System.Drawing.Size(120, 39);
            this.btnGuardarDo.TabIndex = 25;
            this.btnGuardarDo.Text = "Guardar";
            this.btnGuardarDo.UseVisualStyleBackColor = true;
            this.btnGuardarDo.Click += new System.EventHandler(this.btnGuardarDo_Click);
            // 
            // btnNuevoDe
            // 
            this.btnNuevoDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDe.Location = new System.Drawing.Point(371, 278);
            this.btnNuevoDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoDe.Name = "btnNuevoDe";
            this.btnNuevoDe.Size = new System.Drawing.Size(120, 39);
            this.btnNuevoDe.TabIndex = 24;
            this.btnNuevoDe.Text = "Nuevo";
            this.btnNuevoDe.UseVisualStyleBackColor = true;
            this.btnNuevoDe.Click += new System.EventHandler(this.btnNuevoDe_Click);
            // 
            // txtIdDemandado
            // 
            this.txtIdDemandado.Location = new System.Drawing.Point(145, 229);
            this.txtIdDemandado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdDemandado.Name = "txtIdDemandado";
            this.txtIdDemandado.Size = new System.Drawing.Size(80, 30);
            this.txtIdDemandado.TabIndex = 23;
            this.txtIdDemandado.Visible = false;
            // 
            // lblContDe
            // 
            this.lblContDe.AutoSize = true;
            this.lblContDe.Location = new System.Drawing.Point(723, 305);
            this.lblContDe.Name = "lblContDe";
            this.lblContDe.Size = new System.Drawing.Size(75, 25);
            this.lblContDe.TabIndex = 22;
            this.lblContDe.Text = "label11";
            // 
            // btnCancelarDe
            // 
            this.btnCancelarDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDe.Location = new System.Drawing.Point(540, 278);
            this.btnCancelarDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarDe.Name = "btnCancelarDe";
            this.btnCancelarDe.Size = new System.Drawing.Size(120, 39);
            this.btnCancelarDe.TabIndex = 21;
            this.btnCancelarDe.Text = "Cancelar";
            this.btnCancelarDe.UseVisualStyleBackColor = true;
            this.btnCancelarDe.Click += new System.EventHandler(this.btnCancelarDe_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "DOMICILIO";
            // 
            // btnEliminarDe
            // 
            this.btnEliminarDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDe.Location = new System.Drawing.Point(200, 278);
            this.btnEliminarDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarDe.Name = "btnEliminarDe";
            this.btnEliminarDe.Size = new System.Drawing.Size(120, 39);
            this.btnEliminarDe.TabIndex = 17;
            this.btnEliminarDe.Text = "Eliminar";
            this.btnEliminarDe.UseVisualStyleBackColor = true;
            this.btnEliminarDe.Click += new System.EventHandler(this.btnEliminarDe_Click);
            // 
            // btnEditarDe
            // 
            this.btnEditarDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDe.Location = new System.Drawing.Point(28, 278);
            this.btnEditarDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarDe.Name = "btnEditarDe";
            this.btnEditarDe.Size = new System.Drawing.Size(120, 39);
            this.btnEditarDe.TabIndex = 16;
            this.btnEditarDe.Text = "Editar";
            this.btnEditarDe.UseVisualStyleBackColor = true;
            this.btnEditarDe.Click += new System.EventHandler(this.btnEditarDe_Click);
            // 
            // dgwDomicilio
            // 
            this.dgwDomicilio.AllowUserToAddRows = false;
            this.dgwDomicilio.AllowUserToDeleteRows = false;
            this.dgwDomicilio.AllowUserToOrderColumns = true;
            this.dgwDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDomicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarDo});
            this.dgwDomicilio.Location = new System.Drawing.Point(682, 411);
            this.dgwDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwDomicilio.MultiSelect = false;
            this.dgwDomicilio.Name = "dgwDomicilio";
            this.dgwDomicilio.ReadOnly = true;
            this.dgwDomicilio.RowTemplate.Height = 24;
            this.dgwDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDomicilio.Size = new System.Drawing.Size(804, 236);
            this.dgwDomicilio.TabIndex = 15;
            this.dgwDomicilio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDomicilio_CellContentClick);
            this.dgwDomicilio.DoubleClick += new System.EventHandler(this.dgwDomicilio_DoubleClick);
            // 
            // EliminarDo
            // 
            this.EliminarDo.HeaderText = "Eliminar";
            this.EliminarDo.Name = "EliminarDo";
            this.EliminarDo.ReadOnly = true;
            this.EliminarDo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EliminarDo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtDirecc
            // 
            this.txtDirecc.Location = new System.Drawing.Point(145, 417);
            this.txtDirecc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDirecc.Multiline = true;
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(515, 84);
            this.txtDirecc.TabIndex = 14;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(145, 529);
            this.txtRazon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(515, 30);
            this.txtRazon.TabIndex = 13;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(145, 181);
            this.txtRut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(515, 30);
            this.txtRut.TabIndex = 11;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            this.txtRut.Validated += new System.EventHandler(this.txtRut_Validated);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 130);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(515, 30);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnGuardarDe
            // 
            this.btnGuardarDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDe.Location = new System.Drawing.Point(28, 278);
            this.btnGuardarDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarDe.Name = "btnGuardarDe";
            this.btnGuardarDe.Size = new System.Drawing.Size(120, 39);
            this.btnGuardarDe.TabIndex = 8;
            this.btnGuardarDe.Text = "Guardar";
            this.btnGuardarDe.UseVisualStyleBackColor = true;
            this.btnGuardarDe.Click += new System.EventHandler(this.btnGuardarDe_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Diligencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dirección";
            // 
            // dgwDemandado
            // 
            this.dgwDemandado.AllowUserToAddRows = false;
            this.dgwDemandado.AllowUserToDeleteRows = false;
            this.dgwDemandado.AllowUserToOrderColumns = true;
            this.dgwDemandado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDemandado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarDe});
            this.dgwDemandado.Location = new System.Drawing.Point(682, 89);
            this.dgwDemandado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwDemandado.MultiSelect = false;
            this.dgwDemandado.Name = "dgwDemandado";
            this.dgwDemandado.ReadOnly = true;
            this.dgwDemandado.RowTemplate.Height = 24;
            this.dgwDemandado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDemandado.Size = new System.Drawing.Size(804, 214);
            this.dgwDemandado.TabIndex = 3;
            this.dgwDemandado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDemandado_CellContentClick);
            this.dgwDemandado.DoubleClick += new System.EventHandler(this.dgwDemandado_DoubleClick);
            // 
            // EliminarDe
            // 
            this.EliminarDe.HeaderText = "Eliminar";
            this.EliminarDe.Name = "EliminarDe";
            this.EliminarDe.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "DEMANDADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Demandado";
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // frmDemandado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 753);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDemandado";
            this.Text = ".:. Sistema de registro .:.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDemandado_FormClosing);
            this.Load += new System.EventHandler(this.frmDemandado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDemandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgwListado;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkEliminarDe;
        private System.Windows.Forms.Button btnBuscarDe;
        private System.Windows.Forms.TextBox txtBuscarDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoDo;
        private System.Windows.Forms.TextBox txtIdDomicilio;
        private System.Windows.Forms.Button btnCancelarDo;
        private System.Windows.Forms.Button btnEliminarDo;
        private System.Windows.Forms.Button btnEditarDo;
        private System.Windows.Forms.Button btnGuardarDo;
        private System.Windows.Forms.Button btnNuevoDe;
        private System.Windows.Forms.TextBox txtIdDemandado;
        private System.Windows.Forms.Label lblContDe;
        private System.Windows.Forms.Button btnCancelarDe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminarDe;
        private System.Windows.Forms.Button btnEditarDe;
        private System.Windows.Forms.DataGridView dgwDomicilio;
        private System.Windows.Forms.TextBox txtDirecc;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardarDe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgwDemandado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EliminarDe;
        private System.Windows.Forms.ComboBox cbBuscarDe;
        private System.Windows.Forms.Label lblContDo;
        private System.Windows.Forms.ComboBox cbBuscarDo;
        private System.Windows.Forms.CheckBox chkEliminarDo;
        private System.Windows.Forms.Button btnBuscarDo;
        private System.Windows.Forms.TextBox txtBuscarDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EliminarDo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbBuscartt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblrepresent;
        private System.Windows.Forms.TextBox txtRepresent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConfiguracionDB;
        private System.Windows.Forms.ComboBox cbTPersona;
    }
}