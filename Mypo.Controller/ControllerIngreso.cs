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
    public class ControllerIngreso
    {

        public static DataTable Listar()
        {
            DAOIngreso dao = new DAOIngreso();
            return dao.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DAOIngreso dao = new DAOIngreso();
            return dao.Buscar(valor);

        }

        public static string Insertar(int idProveedor, int idUsuario, string tipoComprobante, string folio,
                                      string numLicencia, decimal impuesto, decimal total, DataTable detalle)
        {
            DAOIngreso dao = new DAOIngreso();
            Ingreso i = new Ingreso();
            i.IdProveedor = idProveedor;
            i.IdUsuario = idUsuario;
            i.TipoComprobante = tipoComprobante;
            i.Folio = folio;
            i.NumLicencia = numLicencia;
            i.Impuesto = impuesto;
            i.Total = total;
            i.Detalles = detalle;
            return dao.Insertar(i);

        }

        public static string Cancelar(int id)
        {
            DAOIngreso dao = new DAOIngreso();
            return dao.Cancelar(id);
        }

        public static DataTable BuscarCodigo(string valor)
        {
            DAOIngreso dao = new DAOIngreso();
            return dao.BuscarCodigo(valor);

        }

        public static DataTable MostarDetalle(int id)
        {
            DAOIngreso dao = new DAOIngreso();
            return dao.ListarDetalle(id);

        }
    }
}
