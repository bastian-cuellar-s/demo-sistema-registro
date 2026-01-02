using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Ddemandado
    {

        private int id_demandado;
        private string nombre;
        private string rut;
        private string represent;
        private string texto_buscar;


        public int Id_demandado
        {
            get { return id_demandado; }
            set { id_demandado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string Texto_buscar
        {
            get { return texto_buscar; }
            set { texto_buscar = value; }
        }

        public string Represent
        {
            get { return represent; }
            set { represent = value; }
        }

        public Ddemandado()
        {
        }

        public Ddemandado(int id_demandado, string nombre, string rut, string represent)
        {
            this.Id_demandado = id_demandado;
            this.Nombre = nombre;
            this.Rut = rut;
            this.Represent = represent;

        }
        //metodo Insertar
        public string Insertar(Ddemandado demandado)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                //DB
                sqlcon.ConnectionString = conexion.cn;
                sqlcon.Open();
                //comando
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_insertar_demandado";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Parid_demandado = new SqlParameter();
                Parid_demandado.ParameterName = "@id_demandado";
                Parid_demandado.DbType = DbType.Int32;
                Parid_demandado.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(Parid_demandado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.DbType = DbType.String;
                ParNombre.Size = 50;
                ParNombre.Value = demandado.nombre;
                sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParRut = new SqlParameter();
                ParRut.ParameterName = "@rut";
                ParRut.DbType = DbType.String;
                ParRut.Size = 15;
                ParRut.Value = demandado.rut;
                sqlcmd.Parameters.Add(ParRut);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rpta;
        }

        public string InsertarR(Ddemandado demandado)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                //DB
                sqlcon.ConnectionString = conexion.cn;
                sqlcon.Open();
                //comando
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_insertar_demandadoR";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Parid_demandado = new SqlParameter();
                Parid_demandado.ParameterName = "@id_demandado";
                Parid_demandado.DbType = DbType.Int32;
                Parid_demandado.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(Parid_demandado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.DbType = DbType.String;
                ParNombre.Size = 50;
                ParNombre.Value = demandado.nombre;
                sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParRut = new SqlParameter();
                ParRut.ParameterName = "@rut";
                ParRut.DbType = DbType.String;
                ParRut.Size = 15;
                ParRut.Value = demandado.rut;
                sqlcmd.Parameters.Add(ParRut);

                SqlParameter ParRepresent = new SqlParameter();
                ParRepresent.ParameterName = "@represent";
                ParRepresent.DbType = DbType.String;
                ParRepresent.Size = 50;
                ParRepresent.Value = demandado.represent;
                sqlcmd.Parameters.Add(ParRepresent);


                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rpta;
        }

        //Metodo Editar
        public string Editar(Ddemandado demandado)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                //DB
                sqlcon.ConnectionString = conexion.cn;
                sqlcon.Open();
                //comando
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_editar_demandado";
                sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdDemandado = new SqlParameter();
                ParIdDemandado.ParameterName = "@id_demandado";
                ParIdDemandado.DbType = DbType.Int32;
                ParIdDemandado.Value = demandado.id_demandado;
                sqlcmd.Parameters.Add(ParIdDemandado);


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.DbType = DbType.String;
                ParNombre.Size = 50;
                ParNombre.Value = demandado.nombre;
                sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParRut = new SqlParameter();
                ParRut.ParameterName = "@rut";
                ParRut.DbType = DbType.String;
                ParRut.Size = 15;
                ParRut.Value = demandado.rut;
                sqlcmd.Parameters.Add(ParRut);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rpta;
        }

        public string EditarR(Ddemandado demandado)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                //DB
                sqlcon.ConnectionString = conexion.cn;
                sqlcon.Open();
                //comando
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_editar_demandadoR";
                sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdDemandado = new SqlParameter();
                ParIdDemandado.ParameterName = "@id_demandado";
                ParIdDemandado.DbType = DbType.Int32;
                ParIdDemandado.Value = demandado.id_demandado;
                sqlcmd.Parameters.Add(ParIdDemandado);


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.DbType = DbType.String;
                ParNombre.Size = 50;
                ParNombre.Value = demandado.nombre;
                sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParRut = new SqlParameter();
                ParRut.ParameterName = "@rut";
                ParRut.DbType = DbType.String;
                ParRut.Size = 15;
                ParRut.Value = demandado.rut;
                sqlcmd.Parameters.Add(ParRut);

                SqlParameter ParRepresent = new SqlParameter();
                ParRepresent.ParameterName = "@represent";
                ParRepresent.DbType = DbType.String;
                ParRepresent.Size = 50;
                ParRepresent.Value = demandado.represent;
                sqlcmd.Parameters.Add(ParRepresent);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rpta;
        }

        //Metodo Eliminar
        public string Eliminar(Ddemandado demandado)
        {

            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                //DB
                sqlcon.ConnectionString = conexion.cn;
                sqlcon.Open();
                //comando
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_eliminar_demandado";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDemandado = new SqlParameter();
                ParIdDemandado.ParameterName = "@id_demandado";
                ParIdDemandado.DbType = DbType.Int32;
                ParIdDemandado.Value = demandado.Id_demandado;
                sqlcmd.Parameters.Add(ParIdDemandado);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rpta;
        }

        //Metodo Mostrar
        public DataTable Mostrar()
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_mostrar_demandado";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }

            return dtresultado;
        }

        public DataTable Mostrartodo()
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_mostrar_todo";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }

            return dtresultado;
        }
        public DataTable Mostrardd(int fk_id_demandado)
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_mostrar_demandadoD";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Parid_domicilio = new SqlParameter();
                Parid_domicilio.ParameterName = "@fk_id_demandado";
                Parid_domicilio.DbType = DbType.Int32;
                Parid_domicilio.Value = fk_id_demandado;
                sqlcmd.Parameters.Add(Parid_domicilio);

                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }

            return dtresultado;
        }

        public DataTable buscar_nombre(Ddemandado demandado)
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_demandado";

                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextBuscar = new SqlParameter();
                ParTextBuscar.ParameterName = "@textobuscar";
                ParTextBuscar.DbType = DbType.String;
                ParTextBuscar.Size = 50;
                ParTextBuscar.Value = demandado.texto_buscar;
                sqlcmd.Parameters.Add(ParTextBuscar);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }

            return dtresultado;
        }

        public DataTable buscar_rut(Ddemandado demandado)
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_rut";

                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextBuscar = new SqlParameter();
                ParTextBuscar.ParameterName = "@textobuscar";
                ParTextBuscar.DbType = DbType.String;
                ParTextBuscar.Size = 50;
                ParTextBuscar.Value = demandado.texto_buscar;
                sqlcmd.Parameters.Add(ParTextBuscar);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }

            return dtresultado;
        }

        public DataTable buscar_represent(Ddemandado demandado)
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_represent";

                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextBuscar = new SqlParameter();
                ParTextBuscar.ParameterName = "@textobuscar";
                ParTextBuscar.DbType = DbType.String;
                ParTextBuscar.Size = 50;
                ParTextBuscar.Value = demandado.texto_buscar;
                sqlcmd.Parameters.Add(ParTextBuscar);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }

            return dtresultado;
        }
    }
}