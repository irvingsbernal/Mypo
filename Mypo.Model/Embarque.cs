using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mypo.Model
{
    public class Embarque
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public Image Imagen { get; set; }
        public bool Estado { get; set; }
    }
}
