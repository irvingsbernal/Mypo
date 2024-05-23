using System;
using System.Windows.Forms;
using Mypo.Model;

namespace Mypo.View.Administrador.ViewPreventa
{
    public partial class DetalleProducto : Form
    {
        public DetalleProducto(Producto p)
        {
            InitializeComponent();

            lblNombre.Text = p.Nombre;
            lblDescripcion.Text = p.Descripcion;
            lblCosto.Text = "$ "+p.PrecioVenta.ToString("#0.00#") + " c/u";
            picbFoto.Image = p.Imagen;
            this.Text = p.Nombre;

            if(p.Stock == 0)
            {
                lblStock.Text = "Disponibilidad: Actualmente no disponible";
            }
            else
            {
                lblStock.Text = "Disponibilidad: " + p.Stock + " piezas.";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
