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
    public class ControllerUsuario
    {

        public static DataTable Listar()
        {
            DAOUsuario dao = new DAOUsuario();

            return dao.Listar();
        }

        public static DataTable ListarRoles()
        {
            DAOUsuario dao = new DAOUsuario();

            return dao.ListarRoles();
        }

        public static DataTable Buscar(string valor)
        {
            DAOUsuario dao = new DAOUsuario();

            return dao.Buscar(valor);
        }

        public static string Insertar(int idrol, string nombre, string primer_apellido, string segundo_apellido,
                                      string nss, string rfc, string direccion, string telefono, string email, string contrasenia, Image foto)
        {
            DAOUsuario dao = new DAOUsuario();
            string existe = dao.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "El usuario ya esta registrado";
            }
            else
            {
                Usuario u = new Usuario();

                u.IdRol = idrol;
                u.Nombre = nombre;
                u.Primer_Apellido = primer_apellido;
                u.Segundo_Apellido = segundo_apellido;
                u.NSS = nss;
                u.RFC = rfc;
                u.Direccion = direccion;
                u.Telefono = telefono;
                u.Email = email;
                u.Contrasenia = contrasenia;
                u.foto = foto;

                return dao.Insertar(u);
            }
        }

        public static string Actualizar(int id,int idrol,string nombreAnterior, string nombre, string primer_apellido, string segundo_apellido,
                                      string nss, string rfc, string direccion, string telefono, string email, string contrasenia, Image foto)
        {
            DAOUsuario dao = new DAOUsuario();
            Usuario u = new Usuario();

            if (nombreAnterior.Equals(nombre))
            {
                u.Id = id;
                u.IdRol = idrol;
                u.Nombre = nombre;
                u.Primer_Apellido = primer_apellido;
                u.Segundo_Apellido = segundo_apellido;
                u.NSS = nss;
                u.RFC = rfc;
                u.Direccion = direccion;
                u.Telefono = telefono;
                u.Email = email;
                u.Contrasenia = contrasenia;
                u.foto = foto;

                return dao.Actualizar(u);
            }
            else
            {
                string existe = dao.Existe(nombre);
                if (existe.Equals("1"))
                {
                    return "El usuario ya esta registrado";
                }
                else
                {
                    u.Id = id;
                    u.IdRol = idrol;
                    u.Nombre = nombre;
                    u.Primer_Apellido = primer_apellido;
                    u.Segundo_Apellido = segundo_apellido;
                    u.NSS = nss;
                    u.RFC = rfc;
                    u.Direccion = direccion;
                    u.Telefono = telefono;
                    u.Email = email;
                    u.Contrasenia = contrasenia;
                    u.foto = foto;

                    return dao.Actualizar(u);
                }
            }
        }


        public static string Eliminar(int id)
        {
            DAOUsuario dao = new DAOUsuario();
            return dao.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DAOUsuario dao = new DAOUsuario();
            return dao.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DAOUsuario dao = new DAOUsuario();
            return dao.Desactivar(id);
        }
    }
}
