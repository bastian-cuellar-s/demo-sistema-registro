using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;


namespace CapaNegocios
{
    public class Ndemandado
    {
        
       public static string Insertar(string nombre, string rut)
        {
            Ddemandado obj = new Ddemandado();
            obj.Nombre = nombre;
            obj.Rut = rut;
            return obj.Insertar(obj);
        }
        
        public static string InsertarR(string nombre, string rut, string represent)
        {
            Ddemandado obj = new Ddemandado();
            obj.Nombre = nombre;
            obj.Rut = rut;
            obj.Represent = represent;
            return obj.InsertarR(obj);
        }


        public static string Editar(int id_demandado, string nombre, string rut)
        {
            Ddemandado obj = new Ddemandado();
            obj.Id_demandado = id_demandado;
            obj.Nombre = nombre;
            obj.Rut = rut;
            return obj.Editar(obj);
        }

        public static string EditarR(int id_demandado, string nombre, string rut, string represent)
        {
            Ddemandado obj = new Ddemandado();
            obj.Id_demandado = id_demandado;
            obj.Nombre = nombre;
            obj.Rut = rut;
            obj.Represent = represent;
            return obj.EditarR(obj);
        }


        public static string Eliminar(int id_demandado)
        {
            Ddemandado obj = new Ddemandado();
            obj.Id_demandado = id_demandado;
            return obj.Eliminar(obj);
        }

        public static DataTable Mostrar()
        {
            return new Ddemandado().Mostrar();
        }

        public static DataTable Mostrardd(int fk_id_demandado)
        {
            Ddemandado obj = new Ddemandado();
            obj.Id_demandado = fk_id_demandado;
            return obj.Mostrardd(fk_id_demandado);
        }

        public static DataTable MostrarTodo()
        {
            return new Ddemandado().Mostrartodo();
        }

        public static DataTable Buscar_nombre(string text)
        {
            Ddemandado obj = new Ddemandado();
            obj.Texto_buscar = text;
            return obj.buscar_nombre(obj);
        }

        public static DataTable Buscar_rut(string text)
        {
            Ddemandado obj = new Ddemandado();
            obj.Texto_buscar = text;
            return obj.buscar_rut(obj);
        }

        public static DataTable Buscar_represent(string text)
        {
            Ddemandado obj = new Ddemandado();
            obj.Texto_buscar = text;
            return obj.buscar_represent(obj);
        }
    }

}
