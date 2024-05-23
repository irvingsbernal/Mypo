using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mypo.Model
{
    public static class Cache
    {

        public static int Id { get; set; }
        public static int IdRol { get; set; }
        public static string Nombre { get; set; }
        public static string Primer_Apellido { get; set; }
        public static string Segundo_Apellido { get; set; }
        public static string NSS { get; set; }
        public static string RFC { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }
        public static string Email { get; set; }
        public static string Clave { get; set; }
        public static int Estado { get; set; }
        public static Image Foto { get; set; }
    }
}
