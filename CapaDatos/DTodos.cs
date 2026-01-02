using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DTodos
    {

        private string nombre;
        private string rut;
        private string direcc;
        private string razon;
        private string represent;
        private string texto_buscar;

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

        public string Direcc
        {
            get { return direcc; }
            set { direcc = value; }
        }

        public string Razon
        {
            get { return razon; }
            set { razon = value; }
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

        public DTodos(){}

        public DTodos(string nombre, string rut, string direcc, string razon, string represent)
        {
            this.Nombre = nombre;
            this.Rut = rut;
            this.Direcc = direcc;
            this.Razon = razon;
            this.Represent = represent;

        }

        public DataTable Mostrar()
        {
            DataTable dtresultado = new DataTable("todos");
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

        public DataTable buscar_nombre(DTodos demandado)
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_nombrett";

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

        public DataTable buscar_rut(DTodos demandado)
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_ruttt";

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

        public DataTable buscar_direcc(DTodos domicilio)
        {
            DataTable dtresultado = new DataTable("domicilio");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_direcctt";

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

        public DataTable buscar_razon(DTodos domicilio)
        {
            DataTable dtresultado = new DataTable("domicilio");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_razontt";

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

        public DataTable buscar_represent(DTodos domicilio)
        {
            DataTable dtresultado = new DataTable("demandado");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "sp_buscar_representtt";

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
