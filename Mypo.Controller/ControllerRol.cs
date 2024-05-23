using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mypo.DAO;
using Mypo.Model;

namespace Mypo.Controller
{
    public class ControllerRol
    {

        public static DataTable Listar()
        {
            DAORol Datos = new DAORol();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DAORol Datos = new DAORol();
            return Datos.Buscar(valor);

        }

        public static string Insertar(string nombre, string descripcion)
        {
            DAORol Datos = new DAORol();
            string existe = Datos.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "Este rol ya se encuentra registrado";
            }
            else
            {
                Rol r = new Rol();
                r.Nombre = nombre;
                r.Descripcion = descripcion;
                return Datos.Insertar(r);
            }

        }

        public static string Actualizar(int id, string nombreAnterior, string nombre, string descripcion)
        {
            DAORol Datos = new DAORol();
            Rol r = new Rol();

            if (nombreAnterior.Equals(nombre))
            {
                r.Id = id;
                r.Nombre = nombre;
                r.Descripcion = descripcion;
                return Datos.Actualizar(r);
            }
            else
            {
                string existe = Datos.Existe(nombre);
                if (existe.Equals("1"))
                {
                    return "Este rol ya se encuentra registrado";
                }
                else
                {
                    r.Id = id;
                    r.Nombre = nombre;
                    r.Descripcion = descripcion;
                    return Datos.Actualizar(r);
                }
            }


        }

        public static string Eliminar(int id)
        {
            DAORol Datos = new DAORol();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DAORol Datos = new DAORol();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DAORol Datos = new DAORol();
            return Datos.Desactivar(id);
        }

    }
}
