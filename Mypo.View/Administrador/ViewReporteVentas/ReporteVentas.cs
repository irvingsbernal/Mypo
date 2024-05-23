using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mypo.Controller;
using Mypo.View.Administrador.ViewReporteVenta;

namespace Mypo.View.Administrador.ViewReporteVentas
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            try
            {
                dgvLista.DataSource = ControllerVenta.ListarVentasEntreFechas(Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                FormatoLista();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormatoLista()
        {
            for(int i= 0;i < dgvLista.Columns.Count;i++)
            {
                dgvLista.Columns[i].Width = 200;
            }
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var datos = ControllerVenta.MostarDetalle(Convert.ToInt32(dgvLista.CurrentRow.Cells["ID"].Value));
                decimal total, subtotal, impuesto;
                impuesto = Convert.ToDecimal(dgvLista.CurrentRow.Cells["Impuesto"].Value);
                total = Convert.ToDecimal(dgvLista.CurrentRow.Cells["Total"].Value);
                subtotal = total / (1 + impuesto);

                DetalleVenta dt = new DetalleVenta(datos, subtotal, total, impuesto);
                dt.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
