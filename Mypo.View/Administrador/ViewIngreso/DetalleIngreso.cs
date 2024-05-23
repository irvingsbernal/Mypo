using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mypo.View.Administrador.ViewIngreso
{
    public partial class DetalleIngreso : Form
    {
        public DetalleIngreso(object datos, decimal subtotal, decimal total, decimal impuesto)
        {
            InitializeComponent();
            dgvDetalleIngreso.DataSource = datos;
            txtDetalleSubTotal.Text = subtotal.ToString("#0.00#");
            txtDetalleImpuesto.Text = (total - subtotal).ToString("#0.00#");
            txtDetalleTotal.Text = total.ToString("#0.00#");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
