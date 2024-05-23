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
using Mypo.Controller;


namespace Mypo.View.Administrador.ViewPreventa
{
    public partial class Preventa : Form
    {

        public int posicionTarjetaX = 18;
        public int posicionTarjetaY = 48;
        public int anchoTarjeta = 382;
        public int altoTarjeta = 223;

        public Preventa()
        {
            InitializeComponent();
        }

        private void Preventa_Load(object sender, EventArgs e)
        {
            try
            {
                ControllerProducto cp = new ControllerProducto();
                var productos = cp.ListarProductosEnPreventa();
                GenerarTarjetas(productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CargarTarjetas(Panel pnl,object card)
        {
            Form form = card as Form;

            form.TopLevel = false;

            form.FormBorderStyle = FormBorderStyle.None;

            form.Dock = DockStyle.Fill;

            pnl.Controls.Add(form);

            pnl.Tag = form;

            form.Show();
        }

        private void GenerarTarjetas(List<Producto> productos)
        {
            foreach(var producto in productos)
            {
                Panel card = new Panel();
                card.Width = anchoTarjeta;
                card.Height = altoTarjeta;
                card.Location = new Point(posicionTarjetaX, posicionTarjetaY);
                posicionTarjetaX = posicionTarjetaX + 405;
                CargarTarjetas(card, new CardProducto(producto));
                pnlCarrusel.Controls.Add(card);
            }
        }

    }
}
