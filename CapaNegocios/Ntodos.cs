using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class Ntodos
    {

        public static DataTable Mostrar()
        {
            return new DTodos().Mostrar();
        }


        public static DataTable Buscar_nombre(string text)
        {
            DTodos obj = new DTodos();
            obj.Texto_buscar = text;
            return obj.buscar_nombre(obj);
        }

        public static DataTable Buscar_rut(string text)
        {
            DTodos obj = new DTodos();
            obj.Texto_buscar = text;
            return obj.buscar_rut(obj);
        }

        public static DataTable Buscar_direcc(string text)
        {
            DTodos obj = new DTodos();
            obj.Texto_buscar = text;
            return obj.buscar_direcc(obj);
        }

        public static DataTable Buscar_razon(string text)
        {
            DTodos obj = new DTodos();
            obj.Texto_buscar = text;
            return obj.buscar_razon(obj);
        }

        public static DataTable Buscar_represent(string text)
        {
            DTodos obj = new DTodos();
            obj.Texto_buscar = text;
            return obj.buscar_represent(obj);
        }
    }
}
