using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mypo.DAO;
using Mypo.Model;

namespace Mypo.Controller
{
    public class ControllerEmbarque
    {

        public static DataTable Listar()
        {
            DAOEmbarque dao = new DAOEmbarque();
            return dao.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DAOEmbarque dao = new DAOEmbarque();
            return dao.Buscar(valor);

        }

        public static DataTable ListarCategorias()
        {
            DAOEmbarque dao = new DAOEmbarque();
            return dao.ListarCategorias();
        }

        public static string Insertar(int idCategoria, string codigo, string nombre,
                                      decimal costo, int stock, string descripcion, Image imagen)
        {
            DAOEmbarque dao = new DAOEmbarque();
            string existe = dao.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El producto ya se encuentra registrado.";
            }
            else
            {
                Embarque e = new Embarque();
                e.IdCategoria = idCategoria;
                e.Codigo = codigo;
                e.Nombre = nombre;
                e.Costo = costo;
                e.Stock = stock;
                e.Descripcion = descripcion;
                e.Imagen = imagen;
                return dao.Insertar(e);

            }

        }

        public static string Actualizar(int idEmbarque, int idCategoria, string nombreAnterior, string codigo, string nombre,
                                        decimal costo, int stock, string descripcion, Image imagen)
        {
            DAOEmbarque dao = new DAOEmbarque();
            Embarque e = new Embarque();

            if (nombreAnterior.Equals(nombre))
            {
                e.Id = idEmbarque;
                e.IdCategoria = idCategoria;
                e.Codigo = codigo;
                e.Nombre = nombre;
                e.Costo = costo;
                e.Stock = stock;
                e.Descripcion = descripcion;
                e.Imagen = imagen;
                return dao.Actualizar(e);
            }
            else
            {
                string existe = dao.Existe(nombre);
                if (existe.Equals("1"))
                {
                    return "El producto ya se encuentra registrado.";
                }
                else
                {
                    e.Id = idEmbarque;
                    e.IdCategoria = idCategoria;
                    e.Codigo = codigo;
                    e.Nombre = nombre;
                    e.Costo = costo;
                    e.Stock = stock;
                    e.Descripcion = descripcion;
                    e.Imagen = imagen;
                    return dao.Actualizar(e);
                }
            }
        }

        public static string Eliminar(int id)
        {
            DAOEmbarque dao = new DAOEmbarque();
            return dao.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DAOEmbarque dao = new DAOEmbarque();
            return dao.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DAOEmbarque dao = new DAOEmbarque();
            return dao.Desactivar(id);
        }
    }
}