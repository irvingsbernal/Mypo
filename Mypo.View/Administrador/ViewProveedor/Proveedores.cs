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

namespace Mypo.View.Administrador.ViewProveedor
{
    public partial class Proveedores : Form
    {
        public Proveedores()
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

        private void Listar()
        {
            try
            {
                dgvProveedores.DataSource = ControllerPersona.ListarProveedores();
                lblTotal.Text = "Proveedores registrados: " + (dgvProveedores.Rows.Count);
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Systema Mypo");
            }
        }

        private void AjustarTabla()
        {
            for (int i = 0; i < dgvProveedores.Columns.Count; i++)
            {
                dgvProveedores.Columns[i].Width = 200;
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProveedores.DataSource = ControllerPersona.BuscarProveedores(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccionProveedor accionProveedor = new AccionProveedor("Agregar proveedor");
            accionProveedor.FormClosed += AccionCerrar;
            accionProveedor.ShowDialog();
        }

        private void AccionCerrar(object sender, FormClosedEventArgs e)
        {
            Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros que se puedan editar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AccionProveedor accionProveedor = new AccionProveedor("Editar proveedor", dgvProveedores.CurrentRow.Cells[0].Value.ToString(), dgvProveedores.CurrentRow.Cells[2].Value.ToString(),
                                                            dgvProveedores.CurrentRow.Cells[3].Value.ToString(), dgvProveedores.CurrentRow.Cells[4].Value.ToString(),
                                                            dgvProveedores.CurrentRow.Cells[5].Value.ToString(), dgvProveedores.CurrentRow.Cells[6].Value.ToString(),
                                                            dgvProveedores.CurrentRow.Cells[7].Value.ToString(), dgvProveedores.CurrentRow.Cells[9].Value.ToString(),
                                                            dgvProveedores.CurrentRow.Cells[8].Value.ToString());
            accionProveedor.FormClosed += AccionCerrar;
            accionProveedor.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedores.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var respuesta = MessageBox.Show("Seguro que quiere eliminar este proveedor", "Sistema Mypo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var resultado = ControllerPersona.Eliminar(Convert.ToInt32(dgvProveedores.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show(resultado, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }
    }
}
