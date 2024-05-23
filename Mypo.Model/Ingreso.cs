using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.Model
{
    public class Ingreso
    {

        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }
        public string TipoComprobante { get; set; }
        public string NumComprobante { get; set; }
        public string NumLicencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Folio { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public int Estado { get; set; }
        public DataTable Detalles { get; set; }

    }
}
