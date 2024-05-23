using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mypo.Model;

namespace Mypo.View.Administrador.ViewPreventa
{
    public partial class CardProducto : Form
    {
        public Producto producto;

        public CardProducto(Producto p)
        {
            InitializeComponent();

            producto = p;

            picbFoto.Image = producto.Imagen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleProducto dtp = new DetalleProducto(producto);
            dtp.ShowDialog();
        }
    }
}
