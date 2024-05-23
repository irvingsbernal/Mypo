using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Mypo.DAO;
using Mypo.Model;

namespace Mypo.Controller
{
    public class ControllerProducto
    {
        public static DataTable Listar()
        {
            DAOProducto dao = new DAOProducto();
            return dao.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DAOProducto dao = new DAOProducto();
            return dao.Buscar(valor);
        }

        public static DataTable ListarCategorias()
        {
            DAOProducto dao = new DAOProducto();
            return dao.ListarCategorias();
        }

        public static string Insertar(int idCategoria, string codigo, string nombre,
                                      decimal precioVenta, int stock, string descripcion, Image imagen, DataTable detalle)
        {
            DAOProducto dao = new DAOProducto();
            string existe = dao.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El producto ya se encuentra registrado.";
            }
            else
            {
                Producto p = new Producto();
                p.IdCategoria = idCategoria;
                p.Codigo = codigo;
                p.Nombre = nombre;
                p.PrecioVenta = precioVenta;
                p.Stock = stock;
                p.Descripcion = descripcion;
                p.Imagen = imagen;
                p.Detalle = detalle;
                return dao.Insertar(p);

            }

        }

        public static DataTable VerDetalle(int id)
        {
            DAOProducto dao = new DAOProducto();
            return dao.VerDetalle(id);
        }

        public static string Actualizar(int idProducto, int idCategoria, string nombreAnterior, string codigo, string nombre,
                                        decimal precioVenta, int stock, string descripcion, Image imagen)
        {
            DAOProducto dao = new DAOProducto();
            Producto p = new Producto();

            if (nombreAnterior.Equals(nombre))
            {
                p.Id = idProducto;
                p.IdCategoria = idCategoria;
                p.Codigo = codigo;
                p.Nombre = nombre;
                p.PrecioVenta = precioVenta;
                p.Stock = stock;
                p.Descripcion = descripcion;
                p.Imagen = imagen;
                return dao.Actualizar(p);
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
                    p.Id = idProducto;
                    p.IdCategoria = idCategoria;
                    p.Codigo = codigo;
                    p.Nombre = nombre;
                    p.PrecioVenta= precioVenta;
                    p.Stock = stock;
                    p.Descripcion = descripcion;
                    p.Imagen = imagen;
                    return dao.Actualizar(p);
                }
            }
        }

        public static string Eliminar(int id)
        {
            DAOProducto dao = new DAOProducto();
            return dao.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DAOProducto dao = new DAOProducto();
            return dao.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DAOProducto dao = new DAOProducto();
            return dao.Desactivar(id);
        }

        public List<Producto> ListarProductosEnPreventa()
        {
            DAOProducto dao = new DAOProducto();

            return dao.ProductosEnPreventa();
        }
    }
}
