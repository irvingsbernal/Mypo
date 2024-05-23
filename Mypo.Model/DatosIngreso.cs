using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.Model
{
    /*Esta clase almacena valores para el modulo de ingresos*/
    public static class DatosIngreso
    {
        /*Datos del proveedor*/
        public static string IDProveedor { get; set; }
        public static string NombreProveedor { get; set; }

        /*Datos del producto*/
        public static int IDProducto { get; set; }
        public static string Codigo { get; set; }
        public static string Nombre { get; set; }
        public static decimal Costo { get; set; }
    }
}
