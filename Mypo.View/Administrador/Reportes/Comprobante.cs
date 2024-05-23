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

namespace Mypo.View.Administrador.Reportes
{
    public partial class Comprobante : Form
    {
        public Comprobante()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //this.venta_generarComprobanteTableAdapter.Fill(this.DataSetMypo.venta_generarComprobante, Variables.idVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
