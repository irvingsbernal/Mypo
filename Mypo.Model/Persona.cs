using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.Model
{
    public class Persona
    {
        public int Id { get; set; }
        public string Tipo_Persona { get; set; }
        public string Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Num_Documento { get; set; }
        public string Direccion { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}
