using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Dbackup
    {
        
        public string backup()
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
                sqlcmd.CommandText = "backup_sisscz";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "Se genero el backup" : "No se genero el backup";

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
        
        
    }
}
