using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmDemandado : Form
    {
        public frmDemandado()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en InitializeComponent: " + ex, "Carga de formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        //
        private void frmDemandado_Load(object sender, EventArgs e)
        {
            // Verificar conexión a la base de datos al iniciar
            VerificarConexionInicial();

            this.MostrarDe();
            this.HabilitarDe(false);
            this.BotonesDe();
            this.MostrarDo();
            this.HabilitarDo(false);
            this.BotonesDo();
            this.MostrarTodo();
            this.demandadoLook();
            this.domicilioLook();
            this.todoLook();

        }

        /// <summary>
        /// Verifica la conexión a la base de datos al iniciar la aplicación
        /// </summary>
        private void VerificarConexionInicial()
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(CapaDatos.conexion.cn))
                {
                    conn.Open();
                    // Conexión exitosa
                }
            }
            catch (Exception ex)
            {
                DialogResult resultado = MessageBox.Show(
                    string.Format("No se pudo conectar a la base de datos.\n\nError: {0}\n\n¿Desea configurar la conexión ahora?", ex.Message),
                    "Error de Conexión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    frmConfiguracionDB frmConfig = new frmConfiguracionDB();
                    if (frmConfig.ShowDialog() == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
            }
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }


        //METODOS Y FUNCIONES PARA LOS DATOS DEL DEMANDADO (nombre,rut)


        private bool IsNuevoDe = false;
        private bool IsEditarDe = false;

        //Limpia los textos de las casillas correspondientes al demandado 
        private void LimpiarDe()
        {
            this.txtNombre.Text = string.Empty;
            this.txtRut.Text = string.Empty;
            this.txtIdDemandado.Text = string.Empty;
            this.txtRepresent.Text = string.Empty;
        }

        //Habilitar los controles del formulario correspondientes al demandado
        private void HabilitarDe(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtRut.ReadOnly = !valor;
            this.txtRepresent.ReadOnly = !valor;
            this.txtIdDemandado.ReadOnly = !valor;
        }

        //Habilitar los botones
        private void BotonesDe()
        {
            if (this.IsNuevoDe || this.IsEditarDe) //Alt + 124
            {
                this.HabilitarDe(true);
                this.btnNuevoDe.Enabled = false;
                this.btnGuardarDe.Visible = true;
                this.btnEditarDe.Visible = false;
                this.btnCancelarDe.Enabled = true;
            }
            else
            {
                this.HabilitarDe(false);
                this.btnNuevoDe.Enabled = true;
                this.btnGuardarDe.Visible = false;
                this.btnEditarDe.Visible = true;
                this.btnCancelarDe.Enabled = false;
            }
        }

        private void OcultarColumnasDe()
        {
            // Proteger si no hay columnas cargadas aún
            if (this.dgwDemandado.Columns.Count > 0)
                this.dgwDemandado.Columns[0].Visible = false;
            if (this.dgwDemandado.Columns.Count > 1)
                this.dgwDemandado.Columns[1].Visible = false;
        }

        //Método Mostrar demandado
        private void MostrarDe()
        {
            this.dgwDemandado.DataSource = Ndemandado.Mostrar();
            this.OcultarColumnasDe();
            lblContDe.Text = "Total de Demandados: " + Convert.ToString(dgwDemandado.Rows.Count);
        }


        private void MostrarDedd()
        {
            this.dgwDemandado.DataSource = Ndemandado.Mostrardd(Convert.ToInt32(this.dgwDomicilio.CurrentRow.Cells["fk_id_demandado"].Value));
            this.OcultarColumnasDe();
            lblContDo.Text = "Total de Registros: " + Convert.ToString(dgwDemandado.Rows.Count);
        }


        //Método BuscarNombre demandado
        private void BuscarNombreDe()
        {
            this.dgwDemandado.DataSource = Ndemandado.Buscar_nombre(this.txtBuscarDe.Text);
            this.OcultarColumnasDe();
            lblContDe.Text = "Total de Registros: " + Convert.ToString(dgwDemandado.Rows.Count);
        }

        private void BuscarNombreDee()
        {
            this.dgwDemandado.DataSource = Ndemandado.Buscar_nombre(this.txtNombre.Text);
            this.OcultarColumnasDe();
            lblContDe.Text = "Total de Registros: " + Convert.ToString(dgwDemandado.Rows.Count);
        }
        private void BuscarRutDee()
        {
            this.dgwDemandado.DataSource = Ndemandado.Buscar_rut(this.txtRut.Text);
            this.OcultarColumnasDe();
            lblContDe.Text = "Total de Registros: " + Convert.ToString(dgwDemandado.Rows.Count);
        }
        private void BuscarRutDe()
        {
            this.dgwDemandado.DataSource = Ndemandado.Buscar_rut(this.txtBuscarDe.Text);
            this.OcultarColumnasDe();
            lblContDe.Text = "Total de Registros: " + Convert.ToString(dgwDemandado.Rows.Count);
        }

        private void BuscarRepresentDe()
        {
            this.dgwDemandado.DataSource = Ndemandado.Buscar_represent(this.txtBuscarDe.Text);
            this.OcultarColumnasDe();
            lblContDe.Text = "Total de Registros: " + Convert.ToString(dgwDemandado.Rows.Count);
        }

        private void BuscarRepresentDee()
        {
            this.dgwDemandado.DataSource = Ndemandado.Buscar_represent(this.txtRepresent.Text);
            this.OcultarColumnasDe();
            lblContDe.Text = "Total de Registros: " + Convert.ToString(dgwDemandado.Rows.Count);
        }
        private void btnBuscarDe_Click(object sender, EventArgs e)
        {

            if (cbBuscarDe.Text == "Nombre")
            {
                this.BuscarNombreDe();
            }
            if(cbBuscarDe.Text == "Rut")
            {
                this.BuscarRutDe();
            }
        }

        private void txtBuscarDe_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscarDe.Text == "Nombre")
            {
                this.BuscarNombreDe();
            }
            if (cbBuscarDe.Text == "Rut")
            {
                this.BuscarRutDe();
            }

            if (cbBuscarDe.Text == "Representante")
            {
                this.BuscarRepresentDe();
            }
        }

        private void btnNuevoDe_Click(object sender, EventArgs e)
        {
            if(this.cbTPersona.Text == "Persona Juridica" || this.cbTPersona.Text == "Persona Natural")
            {
                this.IsNuevoDe = true;
                this.IsEditarDe = false;
                this.BotonesDe();
                this.LimpiarDe();
                this.LimpiarDo();
                this.HabilitarDe(true);
                this.MostrarDe();
                this.MostrarDo();
                this.txtNombre.Focus();
            }
            else
            {
                this.MensajeError("Debe seleccionar un tipo de persona");
            }
            
        }

        private void btnGuardarDe_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcon.SetError(txtNombre, "Ingrese un Nombre");
                }
                else
                {
                    if (this.IsNuevoDe)
                    {
                        if(this.cbTPersona.Text == "Persona Natural") {
                           rpta = Ndemandado.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                        this.txtRut.Text.Trim());
                        }
                        
                        if(this.cbTPersona.Text == "Persona Juridica")
                        {
                            rpta = Ndemandado.InsertarR(this.txtNombre.Text.Trim().ToUpper(),
                        this.txtRut.Text.Trim(), this.txtRepresent.Text.Trim().ToUpper());
                        }

                    }
                    else
                    {
                        if (this.cbTPersona.Text == "Persona Natural")
                        {

                            rpta = Ndemandado.Editar(Convert.ToInt32(this.txtIdDemandado.Text),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtRut.Text.Trim());
                        }
                        if (this.cbTPersona.Text == "Persona Juridica")
                        {
                            rpta = Ndemandado.EditarR(Convert.ToInt32(this.txtIdDemandado.Text),
                          this.txtNombre.Text.Trim().ToUpper(),
                          this.txtRut.Text.Trim(), this.txtRepresent.Text.Trim().ToUpper());
                        }

                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevoDe)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevoDe = false;
                    this.IsEditarDe = false;
                    this.BotonesDe();
                    this.LimpiarDe();
                    this.MostrarDe();
                    this.MostrarDo();
                    this.MostrarTodo();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarDe_Click(object sender, EventArgs e)
        {
            if (!this.txtIdDemandado.Text.Equals(""))
            {
                this.IsEditarDe = true;
                this.BotonesDe();
                this.HabilitarDe(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void btnCancelarDe_Click(object sender, EventArgs e)
        {
            this.IsNuevoDe = false;
            this.IsEditarDe = false;
            this.BotonesDe();
            this.LimpiarDe();
            this.HabilitarDe(false);
        }

        private void btnEliminarDe_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwDemandado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = Ndemandado.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.MostrarDe();
                    this.MostrarDo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkEliminarDe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminarDe.Checked)
            {
                this.dgwDemandado.Columns[0].Visible = true;
            }
            else
            {
                this.dgwDemandado.Columns[0].Visible = false;
            }
        }

        private void dgwDemandado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwDemandado.Columns["EliminarDe"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminarDe = (DataGridViewCheckBoxCell)dgwDemandado.Rows[e.RowIndex].Cells["EliminarDe"];
                ChkEliminarDe.Value = !Convert.ToBoolean(ChkEliminarDe.Value);
            }
        }

        private void dgwDemandado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdDemandado.Text = Convert.ToString(this.dgwDemandado.CurrentRow.Cells["id_demandado"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgwDemandado.CurrentRow.Cells["nombre"].Value);
            this.txtRut.Text = Convert.ToString(this.dgwDemandado.CurrentRow.Cells["rut"].Value);
            this.txtRepresent.Text = Convert.ToString(this.dgwDemandado.CurrentRow.Cells["representante"].Value);
            this.MostrarDott();
            this.tabControl1.SelectedIndex = 1;
            
        }

        private void demandadoLook()
        {
            // Proteger si hay menos columnas de las esperadas
            if (dgwDemandado.Columns.Count > 2)
            {
                dgwDemandado.Columns[2].HeaderText = "Demandado";
                dgwDemandado.Columns[2].Width = 332;
            }

            if (dgwDemandado.Columns.Count > 3)
            {
                dgwDemandado.Columns[3].HeaderText = "Rut";
                dgwDemandado.Columns[3].Width = 130;
            }

            if (dgwDemandado.Columns.Count > 4)
            {
                dgwDemandado.Columns[4].HeaderText = "Representante Legal";
                dgwDemandado.Columns[4].Width = 330;
            }


        }

        //METODOS Y FUNCIONES PARA LOS DATOS DEL DOMICILIO (direcc,razon,fk_id_demandado)

        private bool IsNuevoDo = false;
        private bool IsEditarDo = false;

        //Limpia los textos de las casillas correspondientes al demandado 
        private void LimpiarDo()
        {
            this.txtDirecc.Text = string.Empty;
            this.txtRazon.Text = string.Empty;
            this.txtIdDomicilio.Text = string.Empty;
        }

        //Habilitar los controles del formulario correspondientes al demandado
        private void HabilitarDo(bool valor)
        {
            this.txtDirecc.ReadOnly = !valor;
            this.txtRazon.ReadOnly = !valor;
            this.txtIdDomicilio.ReadOnly = !valor;
        }

        //Habilitar los botones
        private void BotonesDo()
        {
            if (this.IsNuevoDo || this.IsEditarDo) //Alt + 124
            {
                this.HabilitarDo(true);
                this.btnNuevoDo.Enabled = false;
                this.btnGuardarDo.Visible = true;
                this.btnEditarDo.Visible = false;
                this.btnCancelarDo.Enabled = true;
            }
            else
            {
                this.HabilitarDo(false);
                this.btnNuevoDo.Enabled = true;
                this.btnGuardarDo.Visible = false;
                this.btnEditarDo.Visible = true;
                this.btnCancelarDo.Enabled = false;
            }
        }

        private void OcultarColumnasDo()
        {
            // Proteger si la grilla trae menos columnas
            if (this.dgwDomicilio.Columns.Count > 0)
                this.dgwDomicilio.Columns[0].Visible = false;
            if (this.dgwDomicilio.Columns.Count > 1)
                this.dgwDomicilio.Columns[1].Visible = false;
            if (this.dgwDomicilio.Columns.Count > 4)
                this.dgwDomicilio.Columns[4].Visible = false;

        }

        //Método Mostrar demandado
        private void MostrarDo()
        {
            this.dgwDomicilio.DataSource = Ndomicilio.Mostrar();
            this.OcultarColumnasDo();
            lblContDo.Text = "Total de Registros: " + Convert.ToString(dgwDomicilio.Rows.Count);
        }

        private void MostrarDott()
        {
            this.dgwDomicilio.DataSource = Ndomicilio.Mostrartt(Convert.ToInt32(this.dgwDemandado.CurrentRow.Cells["id_demandado"].Value));
            this.OcultarColumnasDo();
            lblContDo.Text = "Total de Registros: " + Convert.ToString(dgwDomicilio.Rows.Count);
        }

        //Método BuscarNombre demandado
        private void BuscarDireccDo()
        {
            this.dgwDomicilio.DataSource = Ndomicilio.Buscar_direcc(this.txtBuscarDo.Text);
            this.OcultarColumnasDo();
            lblContDo.Text = "Total de Registros: " + Convert.ToString(dgwDomicilio.Rows.Count);
        }

        private void BuscarRazonDo()
        {
            this.dgwDomicilio.DataSource = Ndomicilio.Buscar_razon(this.txtBuscarDo.Text);
            this.OcultarColumnasDo();
            lblContDo.Text = "Total de Registros: " + Convert.ToString(dgwDomicilio.Rows.Count);
        }

        private void btnBuscarDo_Click(object sender, EventArgs e)
        {
            if (cbBuscarDo.Text == "Direccion")
            {
                this.BuscarDireccDo();
    
            }
            if (cbBuscarDo.Text == "Razon")
            {
                this.BuscarRazonDo();
            }
        }

        private void txtBuscarDo_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscarDo.Text == "Direccion")
            {
                this.BuscarDireccDo();
            }
            if (cbBuscarDo.Text == "Razon")
            {
                this.BuscarRazonDo();
            }
        }

        private void btnNuevoDo_Click(object sender, EventArgs e)
        {
            if (!this.txtIdDemandado.Text.Equals(""))
            {
                this.IsNuevoDo = true;
                this.IsEditarDo = false;
                this.BotonesDo();
                this.LimpiarDo();
                this.HabilitarDo(true);
                this.txtDirecc.Focus();
            }
            else
            {
                this.MensajeError("Seleccione un demandado, antes de ingresar un Domicilio");
            }
            
        }

        private void btnGuardarDo_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtDirecc.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcon.SetError(txtDirecc, "Ingrese un Dirección");
                }
                else
                {
                    if (this.IsNuevoDo)
                    {
                        rpta = Ndomicilio.Insertar(this.txtDirecc.Text.Trim().ToUpper(),
                            this.txtRazon.Text.Trim(), Convert.ToInt32(this.txtIdDemandado.Text));

                    }
                    else
                    {
                        rpta = Ndomicilio.Editar(Convert.ToInt32(this.txtIdDomicilio.Text),
                            this.txtDirecc.Text.Trim().ToUpper(),
                            this.txtRazon.Text.Trim(), Convert.ToInt32(this.txtIdDemandado.Text));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevoDo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevoDo = false;
                    this.IsEditarDo = false;
                    this.BotonesDo();
                    this.LimpiarDo();
                    this.MostrarDo();
                    this.MostrarDe();
                    this.MostrarTodo();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarDo_Click(object sender, EventArgs e)
        {
            if (!this.txtIdDemandado.Text.Equals("") && !this.txtIdDomicilio.Text.Equals(""))
            {
                this.IsEditarDo = true;
                this.BotonesDo();
                this.HabilitarDo(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void btnCancelarDo_Click(object sender, EventArgs e)
        {
            this.IsNuevoDo = false;
            this.IsEditarDo = false;
            this.BotonesDo();
            this.LimpiarDo();
            this.HabilitarDo(false);
        }

        private void btnEliminarDo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwDomicilio.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = Ndomicilio.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.MostrarDo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkEliminarDo_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkEliminarDo.Checked)
            {
                this.dgwDomicilio.Columns[0].Visible = false;
            }
            else
            {
                this.dgwDomicilio.Columns[0].Visible = true;
            }
        }

        private void chkEliminarDo_CheckedChanged1(object sender, EventArgs e)
        {
            if (chkEliminarDo.Checked)
            {
                this.dgwDomicilio.Columns[0].Visible = true;
            }
            else
            {
                this.dgwDomicilio.Columns[0].Visible = false;
            }
        }

        private void dgwDomicilio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwDomicilio.Columns["EliminarDo"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminarDo = (DataGridViewCheckBoxCell)dgwDomicilio.Rows[e.RowIndex].Cells["EliminarDo"];
                ChkEliminarDo.Value = !Convert.ToBoolean(ChkEliminarDo.Value);
            }
        }

        private void dgwDomicilio_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdDomicilio.Text = Convert.ToString(this.dgwDomicilio.CurrentRow.Cells["id_domicilio"].Value);
            this.txtDirecc.Text = Convert.ToString(this.dgwDomicilio.CurrentRow.Cells["direcc"].Value);
            this.txtRazon.Text = Convert.ToString(this.dgwDomicilio.CurrentRow.Cells["razon"].Value);
            this.txtIdDemandado.Text = Convert.ToString(this.dgwDomicilio.CurrentRow.Cells["fk_id_demandado"].Value);
            this.MostrarDedd();
            this.tabControl1.SelectedIndex = 1;
        }

        private void txtRut_Validated(object sender, EventArgs e)
        {
            this.txtRut.Text = formatearRut(this.txtRut.Text);
        }

        private void chkEliminarDe_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkEliminarDe.Checked)
            {
                this.dgwDemandado.Columns[0].Visible = true;
            }
            else
            {
                this.dgwDemandado.Columns[0].Visible = false;
            }
        }

        private void domicilioLook()
        {
            // Proteger si hay menos columnas de las esperadas
            if (dgwDomicilio.Columns.Count > 2)
            {
                dgwDomicilio.Columns[2].HeaderText = "Domicilio";
                dgwDomicilio.Columns[2].Width = 392;
            }

            if (dgwDomicilio.Columns.Count > 3)
            {
                dgwDomicilio.Columns[3].HeaderText = "Diligencia";
                dgwDomicilio.Columns[3].Width = 150;
            }

        }

        //Mostrar todo
        private void MostrarTodo()
        {
            this.dgwListado.DataSource = Ntodos.Mostrar();
            lblTotal.Text = "Total de Registros del Sistema: " + Convert.ToString(dgwListado.Rows.Count);
        }

        private void todoLook()
        {
            // Proteger si hay menos columnas de las esperadas
            if (dgwListado.Columns.Count > 0)
            {
                dgwListado.Columns[0].HeaderText = "Nombre";
                dgwListado.Columns[0].Width = 350;
            }

            if (dgwListado.Columns.Count > 1)
            {
                dgwListado.Columns[1].HeaderText = "Rut";
                dgwListado.Columns[1].Width = 105;
            }

            if (dgwListado.Columns.Count > 2)
            {
                dgwListado.Columns[2].HeaderText = "Domicilio";
                dgwListado.Columns[2].Width = 350;
            }

            if (dgwListado.Columns.Count > 3)
            {
                dgwListado.Columns[3].HeaderText = "Diligencia";
                dgwListado.Columns[3].Width = 160;
            }

            if (dgwListado.Columns.Count > 4)
            {
                dgwListado.Columns[4].HeaderText = "Representante";
            }

        }


        private void BuscarNombrett()
        {
            this.dgwListado.DataSource = Ntodos.Buscar_nombre(this.txtbuscar.Text);
            lblTotal.Text = "Total de Registros por este Nombre: " + Convert.ToString(dgwListado.Rows.Count);
        }

        private void BuscarRuttt()
        {
            this.dgwListado.DataSource = Ntodos.Buscar_rut(this.txtbuscar.Text);
            lblTotal.Text = "Total de Registros por este Rut: " + Convert.ToString(dgwListado.Rows.Count);
        }

        private void BuscarDirecctt()
        {
            this.dgwListado.DataSource = Ntodos.Buscar_direcc(this.txtbuscar.Text);
            lblTotal.Text = "Total de Registros por este Domicilio: " + Convert.ToString(dgwListado.Rows.Count);
        }

        private void BuscarRazontt()
        {
            this.dgwListado.DataSource = Ntodos.Buscar_razon(this.txtbuscar.Text);
            lblTotal.Text = "Total de Registros por esta Diligencia: " + Convert.ToString(dgwListado.Rows.Count);
        }

        private void BuscarRepresenttt()
        {
            this.dgwListado.DataSource = Ntodos.Buscar_represent(this.txtbuscar.Text);
            lblTotal.Text = "Total de Registros por este Representante: " + Convert.ToString(dgwListado.Rows.Count);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscartt.Text == "Nombre")
            {
                this.BuscarNombrett();
            }
            if (cbBuscartt.Text == "Rut")
            {
                this.BuscarRuttt();
            }
            if (cbBuscartt.Text == "Domicilio")
            {
                this.BuscarDirecctt();
            }
            if (cbBuscartt.Text == "Razon")
            {
                this.BuscarRazontt();
            }

            if (cbBuscartt.Text == "Representante")
            {
                this.BuscarRepresenttt();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscartt.Text == "Nombre")
            {
                this.BuscarNombrett();
            }
            if (cbBuscartt.Text == "Rut")
            {
                this.txtbuscar.Text = formatearRut(this.txtbuscar.Text);
                this.BuscarRuttt();
            }
            if (cbBuscartt.Text == "Domicilio")
            {
                this.BuscarDirecctt();
            }
            if (cbBuscartt.Text == "Razon")
            {
                this.BuscarRazontt();
            }
            if (cbBuscartt.Text == "Representante")
            {
                this.BuscarRepresenttt();
            }
        }

        private void txtbuscar_Validating(object sender, CancelEventArgs e)
        {
            if (cbBuscartt.Text == "Rut")
            {
                this.txtbuscar.Text = formatearRut(this.txtbuscar.Text);
            }
        }

        private void txtBuscarDe_Validating(object sender, CancelEventArgs e)
        {
            if (cbBuscarDe.Text == "Rut")
            {
                this.txtBuscarDe.Text = formatearRut(this.txtBuscarDe.Text);
            }
        }

        public void backup()
        {
            string rpta = "";
            rpta = Nbackup.backup();
        }



        private void cbTPersona_Click(object sender, EventArgs e)
        {
            if (this.cbTPersona.Text == "Persona Juridica")
            {
                this.lblrepresent.Visible = true;
                this.txtRepresent.Visible = true;
            }
            if (this.cbTPersona.Text == "Persona Natural")
            {
                this.lblrepresent.Visible = false;
                this.txtRepresent.Visible = false;
            }
        }

        private void cbTPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbTPersona.Text == "Persona Juridica")
            {
                this.lblrepresent.Visible = true;
                this.txtRepresent.Visible = true;
            }
            if (this.cbTPersona.Text == "Persona Natural")
            {
                this.lblrepresent.Visible = false;
                this.txtRepresent.Visible = false;
            }
        }

        private void frmDemandado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.backup();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
         
           
                this.BuscarNombreDee();
            
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRutDee();
        }

  

        private void txtRepresent_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRepresentDee();
        }

        /// <summary>
        /// Abre el formulario de configuración de base de datos
        /// </summary>
        private void btnConfiguracionDB_Click(object sender, EventArgs e)
        {
            try
            {
                frmConfiguracionDB frmConfig = new frmConfiguracionDB();
                DialogResult resultado = frmConfig.ShowDialog();
                
                if (resultado == DialogResult.OK)
                {
                    // Si se guardó una nueva configuración, ofrecer reiniciar
                    DialogResult reiniciar = MessageBox.Show(
                        "La configuración se guardó correctamente.\n\n" +
                        "¿Desea reiniciar la aplicación ahora para aplicar los cambios?",
                        "Configuración Guardada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    
                    if (reiniciar == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al abrir configuración: {0}", ex.Message),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}


