using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mypo.DAO;
using Mypo.Model;

namespace Mypo.Controller
{
    public class ControllerPersona
    {

        public static DataTable Listar()
        {
            DAOPersona dao = new DAOPersona();
            return dao.Listar();
        }

        public static DataTable ListarProveedores()
        {
            DAOPersona dao = new DAOPersona();
            return dao.ListarProveedores();
        }

        public static DataTable ListarClientes()
        {
            DAOPersona dao = new DAOPersona();
            return dao.ListarClientes();
        }
        public static DataTable Buscar(string valor)
        {
            DAOPersona dao = new DAOPersona();
            return dao.Buscar(valor);

        }
        public static DataTable BuscarProveedores(string valor)
        {
            DAOPersona dao = new DAOPersona();
            return dao.BuscarProveedores(valor);

        }
        public static DataTable BuscarClientes(string valor)
        {
            DAOPersona dao = new DAOPersona();
            return dao.BuscarClientes(valor);

        }

        public static string Insertar(string tipoPersona, string nombre, string primerApe, string segundoApe,
                                      string curp, string rfc, string direccion, string telefono, string email)
        {
            DAOPersona dao = new DAOPersona();
            string existe = dao.Existe(nombre, primerApe, segundoApe);
            if (existe.Equals("1"))
            {
                return "El ítem ya se encuentra registrado.";
            }
            else
            {
                Persona p = new Persona();
                p.Tipo_Persona = tipoPersona;
                p.Nombre = nombre;
                p.Primer_Apellido = primerApe;
                p.Segundo_Apellido = segundoApe;
                p.CURP = curp;
                p.RFC = rfc;
                p.Direccion = direccion;
                p.Telefono = telefono;
                p.Email = email;

                return dao.Insertar(p);
            }

        }

        public static string Actualizar(int idPersona, string tipoPersona, string nombre, string primerApe, string segundoApe,
                                        string nombreAnterior, string primerApeAnterior, string segundoApeAnterior,
                                        string curp, string rfc, string direccion, string telefono, string email)
        {
            DAOPersona dao = new DAOPersona();
            Persona p = new Persona();

            if (nombreAnterior.Equals(nombre) && primerApeAnterior.Equals(primerApe) && segundoApeAnterior.Equals(segundoApe))
            {
                p.Id = idPersona;
                p.Tipo_Persona = tipoPersona;
                p.Nombre = nombre;
                p.Primer_Apellido = primerApe;
                p.Segundo_Apellido = segundoApe;
                p.CURP = curp;
                p.RFC = rfc;
                p.Direccion = direccion;
                p.Telefono = telefono;
                p.Email = email;

                return dao.Actualizar(p);
            }
            else
            {
                string existe = dao.Existe(nombre, primerApe, segundoApe);
                if (existe.Equals("1"))
                {
                    return "El ítem ya se encuentra registrado.";
                }
                else
                {
                    p.Id = idPersona;
                    p.Tipo_Persona = tipoPersona;
                    p.Nombre = nombre;
                    p.Primer_Apellido = primerApe;
                    p.Segundo_Apellido = segundoApe;
                    p.CURP = curp;
                    p.RFC = rfc;
                    p.Direccion = direccion;
                    p.Telefono = telefono;
                    p.Email = email;

                    return dao.Actualizar(p);
                }
            }
        }

        public static string Eliminar(int id)
        {
            DAOPersona dao = new DAOPersona();
            return dao.Eliminar(id);
        }
    }
}