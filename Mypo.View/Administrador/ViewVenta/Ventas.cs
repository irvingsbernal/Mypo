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

namespace Mypo.View.Administrador.ViewVenta
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text.Equals(""))
            {
                this.txtBuscar.Text = "Filtro de busqueda";
                Listar();
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text.Equals("Filtro de busqueda"))
            {
                this.txtBuscar.Text = "";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvVentas.DataSource = ControllerVenta.Buscar(txtBuscar.Text);
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccionVenta accionVenta = new AccionVenta("Nueva venta");
            accionVenta.FormClosed += AccionCerrar;
            accionVenta.ShowDialog();
        }

        private void AccionCerrar(object sender, FormClosedEventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                dgvVentas.DataSource = ControllerVenta.Listar();
                lblTotal.Text = "Ventas registradas: " + dgvVentas.Rows.Count;
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void AjustarTabla()
        {
            for (int i = 0; i < dgvVentas.Columns.Count; i++)
            {
                dgvVentas.Columns[i].Width = 200;
            }
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvIngresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var datos = ControllerVenta.MostarDetalle(Convert.ToInt32(dgvVentas.CurrentRow.Cells["ID"].Value));
                decimal total, subtotal, impuesto;
                impuesto = Convert.ToDecimal(dgvVentas.CurrentRow.Cells["Impuesto"].Value);
                total = Convert.ToDecimal(dgvVentas.CurrentRow.Cells["Total"].Value);
                subtotal = total / (1 + impuesto);

                DetalleVenta dt = new DetalleVenta(datos, subtotal, total, impuesto);
                dt.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvVentas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para anular", "Sistema Mypo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                var respuesta = MessageBox.Show("Seguro que quiere cancelar esta venta","Sistema Mypo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(respuesta == DialogResult.Yes)
                {
                    MessageBox.Show(ControllerVenta.Cancelar(Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value)),"Sistema Mypo");
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
