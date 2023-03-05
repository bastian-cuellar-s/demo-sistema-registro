using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Ddomicilio
    {
        private int id_domicilio;
        private string direcc;
        private string razon;
        private string texto_buscar;
        private int fk_id_demandado;

        public int Id_domicilio { get => id_domicilio; set => id_domicilio = value; }
        public string Direcc { get => direcc; set => direcc = value; }
        public string Razon { get => razon; set => razon = value; }
        public string Texto_buscar { get => texto_buscar; set => texto_buscar = value; }
        public int Fk_id_demandado { get => fk_id_demandado; set => fk_id_demandado = value; }

        public Ddomicilio()
        {
        }

        public Ddomicilio(int id_domicilio, string direcc, string razon, int fk_id_demandado)
        {
            this.Id_domicilio = id_domicilio;
            this.Direcc = direcc;
            this.Razon = razon;
            this.Fk_id_demandado = fk_id_demandado; 

        }
        //metodo Insertar
        public string Insertar(Ddomicilio domicilio)
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
                sqlcmd.CommandText = "sp_insertar_domicilio";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDomicilio = new SqlParameter();
                ParIdDomicilio.ParameterName = "@id_domicilio";
                ParIdDomicilio.DbType = DbType.Int32;
                ParIdDomicilio.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(ParIdDomicilio);

                SqlParameter ParDirecc = new SqlParameter();
                ParDirecc.ParameterName = "@direcc";
                ParDirecc.DbType = DbType.String;
                ParDirecc.Size = 200;
                ParDirecc.Value = domicilio.direcc;
                sqlcmd.Parameters.Add(ParDirecc);

                SqlParameter ParRazon = new SqlParameter();
                ParRazon.ParameterName = "@razon";
                ParRazon.DbType = DbType.String;
                ParRazon.Size = 100;
                ParRazon.Value = domicilio.razon;
                sqlcmd.Parameters.Add(ParRazon);

                SqlParameter ParFkIdDemandado = new SqlParameter();
                ParFkIdDemandado.ParameterName = "@fk_id_demandado";
                ParFkIdDemandado.DbType = DbType.Int32;
                ParFkIdDemandado.Value = domicilio.fk_id_demandado;
                sqlcmd.Parameters.Add(ParFkIdDemandado);

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
        public string Editar(Ddomicilio domicilio)
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
                sqlcmd.CommandText = "sp_editar_domicilio";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Parid_domicilio = new SqlParameter();
                Parid_domicilio.ParameterName = "@id_domicilio";
                Parid_domicilio.DbType = DbType.Int32;
                Parid_domicilio.Value = domicilio.Id_domicilio;
                sqlcmd.Parameters.Add(Parid_domicilio);

                SqlParameter ParDirecc = new SqlParameter();
                ParDirecc.ParameterName = "@direcc";
                ParDirecc.DbType = DbType.String;
                ParDirecc.Size = 200;
                ParDirecc.Value = domicilio.direcc;
                sqlcmd.Parameters.Add(ParDirecc);

                SqlParameter ParRazon = new SqlParameter();
                ParRazon.ParameterName = "@razon";
                ParRazon.DbType = DbType.String;
                ParRazon.Size = 100;
                ParRazon.Value = domicilio.razon;
                sqlcmd.Parameters.Add(ParRazon);

                SqlParameter ParFkIdDemandado = new SqlParameter();
                ParFkIdDemandado.ParameterName = "@fk_id_demandado";
                ParFkIdDemandado.DbType = DbType.Int32;
                ParFkIdDemandado.Value = domicilio.fk_id_demandado;
                sqlcmd.Parameters.Add(ParFkIdDemandado);

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


        //Metodo Eliminar
        public string Eliminar(Ddomicilio domicilio )
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
                sqlcmd.CommandText = "sp_eliminar_domicilio";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Parid_domicilio = new SqlParameter();
                Parid_domicilio.ParameterName = "@id_domicilio";
                Parid_domicilio.DbType = DbType.Int32;
                Parid_domicilio.Value = domicilio.Id_domicilio;
                sqlcmd.Parameters.Add(Parid_domicilio);

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
            DataTable dtresultado = new DataTable("domicilio");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_mostrar_domicilios";
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

        public DataTable Mostrartt(int fk_id_demandado)
        {
            DataTable dtresultado = new DataTable("domicilio");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_mostrar_domicilio";
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

        

        public DataTable buscar_direcc(Ddomicilio domicilio)
        {
            DataTable dtresultado = new DataTable("domicilio");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_direcc";

                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextBuscar = new SqlParameter();
                ParTextBuscar.ParameterName = "@textobuscar";
                ParTextBuscar.DbType = DbType.String;
                ParTextBuscar.Size = 50;
                ParTextBuscar.Value = domicilio.texto_buscar;
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

        public DataTable buscar_razon(Ddomicilio domicilio)
        {
            DataTable dtresultado = new DataTable("domicilio");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_razon";

                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextBuscar = new SqlParameter();
                ParTextBuscar.ParameterName = "@textobuscar";
                ParTextBuscar.DbType = DbType.String;
                ParTextBuscar.Size = 50;
                ParTextBuscar.Value = domicilio.texto_buscar;
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
    
