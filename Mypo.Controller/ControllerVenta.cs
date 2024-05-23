using Mypo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mypo.DAO;

namespace Mypo.Controller
{
    public class ControllerVenta
    {

        public static DataTable Listar()
        {
            DAOVenta dao = new DAOVenta();
            return dao.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DAOVenta dao = new DAOVenta();
            return dao.Buscar(valor);

        }

        

        public static string Insertar(int idUsuario, int idCliente, string numTicket, string tipoComprobante,
                                      string folioComprobante, decimal impuesto, decimal total, DataTable detalles)
        {
            DAOVenta dao = new DAOVenta();
            Venta v = new Venta();
            v.IdUsuario = idUsuario;
            v.IdCliente = idCliente;
            v.NumTicket = numTicket;
            v.TipoComprobante = tipoComprobante;
            v.FolioComprobante = folioComprobante;
            v.Impuesto = impuesto;
            v.Total = total;
            v.Detalles = detalles;

            return dao.Insertar(v);

        }

        public static string Cancelar(int id)
        {
            DAOVenta dao = new DAOVenta();
            return dao.Cancelar(id);
        }

        public static DataTable BuscarCodigo(string valor)
        {
            DAOVenta dao = new DAOVenta();
            return dao.BuscarCodigo(valor);

        }

        public static DataTable BuscarProducto(string valor)
        {
            DAOVenta dao = new DAOVenta();
            return dao.BuscarProducto(valor);

        }

        public static DataTable MostarDetalle(int id)
        {
           DAOVenta dao = new DAOVenta();
            return dao.ListarDetalle(id);
        }

        public static DataTable ListarVentasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            DAOVenta dao = new DAOVenta();
            return dao.ListarVentasEntreFechas(fechaInicio, fechaFin);

        }
    }
}
