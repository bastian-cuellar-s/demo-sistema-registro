using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class Ndomicilio
    {
        public static string Insertar(string direcc, string razon, int fk_id_demandado)
        {
            Ddomicilio obj = new Ddomicilio();
            obj.Direcc = direcc;
            obj.Razon = razon;
            obj.Fk_id_demandado = fk_id_demandado;
            return obj.Insertar(obj);
        }

        public static string Editar(int id_domicilio, string direcc, string razon, int fk_id_demandado)
        {
            Ddomicilio obj = new Ddomicilio();
            obj.Id_domicilio = id_domicilio;
            obj.Direcc = direcc;
            obj.Razon = razon;
            obj.Fk_id_demandado = fk_id_demandado;
            return obj.Editar(obj);
        }

        public static string Eliminar(int id_domicilio)
        {
            Ddomicilio obj = new Ddomicilio();
            obj.Id_domicilio = id_domicilio;
            return obj.Eliminar(obj);
        }

        public static DataTable Mostrar()
        {
            return new Ddomicilio().Mostrar();
        }

        public static DataTable Mostrartt(int fk_id_demandado)
        {
            Ddomicilio obj = new Ddomicilio();
            obj.Fk_id_demandado = fk_id_demandado;
            return  obj.Mostrartt(fk_id_demandado);
        }

        public static DataTable Buscar_direcc(string text)
        {
            Ddomicilio obj = new Ddomicilio();
            obj.Texto_buscar = text;
            return obj.buscar_direcc(obj);
        }

        public static DataTable Buscar_razon(string text)
        {
            Ddomicilio obj = new Ddomicilio();
            obj.Texto_buscar = text;
            return obj.buscar_razon(obj);
        }
    }
}

