using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.Model
{
    public static class DatosVenta
    {
        /*Datos del cliente*/
        public static int IDCliente { get; set; }
        public static string NombreCliente { get; set; }

        /*Datos del producto*/
        public static int IDProducto { get; set; }
        public static string Codigo { get; set; }
        public static string Nombre { get; set; }
        public static decimal Costo { get; set; }
        public static int Stock { get; set; }
    }
}
