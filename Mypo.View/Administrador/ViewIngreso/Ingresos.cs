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

namespace Mypo.View.Administrador.ViewIngreso
{
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccionIngreso accionIngreso = new AccionIngreso("Nuevo ingreso");
            accionIngreso.FormClosed += AccionCerrar;
            accionIngreso.ShowDialog();
        }


        private void AccionCerrar(object sender, FormClosedEventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            try
            {
                dgvIngresos.DataSource = ControllerIngreso.Listar();
                lblTotal.Text = "Ingresos registrados: " + dgvIngresos.Rows.Count;
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void AjustarTabla()
        {
            for (int i = 0; i < dgvIngresos.Columns.Count; i++)
            {
                dgvIngresos.Columns[i].Width = 200;
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
                var datos = ControllerIngreso.MostarDetalle(Convert.ToInt32(dgvIngresos.CurrentRow.Cells["ID"].Value));
                decimal total, subtotal, impuesto;
                impuesto = Convert.ToDecimal(dgvIngresos.CurrentRow.Cells["Impuesto"].Value);
                total = Convert.ToDecimal(dgvIngresos.CurrentRow.Cells["Total"].Value);
                subtotal = total / (1 + impuesto);

                DetalleIngreso dt = new DetalleIngreso(datos, subtotal, total, impuesto);
                dt.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                dgvIngresos.DataSource = ControllerVenta.Buscar(txtBuscar.Text);
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvIngresos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para anular", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var respuesta = MessageBox.Show("Seguro que quiere cancelar esta orden","Sistema Mypo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(respuesta == DialogResult.Yes)
                {
                    MessageBox.Show(ControllerIngreso.Cancelar(Convert.ToInt32(dgvIngresos.CurrentRow.Cells[0].Value)),"Sistema Mypo");
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
