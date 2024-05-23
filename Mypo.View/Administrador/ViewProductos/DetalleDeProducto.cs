using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mypo.View.Administrador.ViewProductos
{
    public partial class DetalleDeProducto : Form
    {
        public DetalleDeProducto(object datos)
        {
            InitializeComponent();
            dgvDetalleProducto.DataSource = datos;

            for(int i = 0; i < dgvDetalleProducto.Columns.Count; i++)
            {
                dgvDetalleProducto.Columns[i].Width = 200;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
