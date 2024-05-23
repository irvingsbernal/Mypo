using Mypo.DAO;
using Mypo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.Controller
{
    public class ControllerCategoria
    {
        public static DataTable Listar()
        {
            DAOCategoria Datos = new DAOCategoria();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DAOCategoria Datos = new DAOCategoria();
            return Datos.Buscar(valor);

        }

        public static string Insertar(string nombre, string descripcion)
        {
            DAOCategoria Datos = new DAOCategoria();
            string existe = Datos.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "La categoría ya se encuentra registrada";
            }
            else
            {
                Categoria c = new Categoria();
                c.Nombre = nombre;
                c.Descripcion = descripcion;
                return Datos.Insertar(c);
            }
                
        }

        public static string Actualizar(int id, string nombreAnterior, string nombre, string descripcion)
        {
            DAOCategoria Datos = new DAOCategoria();
            Categoria c = new Categoria();

            if (nombreAnterior.Equals(nombre))
            {
                c.IdCategoria = id;
                c.Nombre = nombre;
                c.Descripcion = descripcion;
                return Datos.Actualizar(c);
            }
            else
            {
                string existe = Datos.Existe(nombre);
                if (existe.Equals("1"))
                {
                    return "La categoría ya se encuentra registrada";
                }
                else
                {
                    c.IdCategoria = id;
                    c.Nombre = nombre;
                    c.Descripcion = descripcion;
                    return Datos.Actualizar(c);
                }
            }
            
            
        }

        public static string Eliminar(int id)
        {
            DAOCategoria Datos = new DAOCategoria();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DAOCategoria Datos = new DAOCategoria();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DAOCategoria Datos = new DAOCategoria();
            return Datos.Desactivar(id);
        }
    }
}
