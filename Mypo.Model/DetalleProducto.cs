using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.Model
{
    public static class DetalleProducto
    {

        public static int IDProducto { get; set; }
        public static string Nombre { get; set; }
        public static int Stock { get; set; }
        public static string Unidad { get; set; }
        public static DataTable Detalle { get; set; }
    }
}
