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

namespace Mypo.View.Administrador.ViewCliente
{
    public partial class Clientes : Form
    {
        public Clientes()
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

        private void Clientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                dgvClientes.DataSource = ControllerPersona.ListarClientes();
                lblTotal.Text = "Clientes registrados: " + (dgvClientes.Rows.Count);
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Systema Mypo");
            }
        }

        private void AjustarTabla()
        {
            for(int i = 0; i < dgvClientes.Columns.Count; i++)
            {
                dgvClientes.Columns[i].Width = 200;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccionCliente accionCliente = new AccionCliente("Agregar cliente");
            accionCliente.FormClosed += AccionCerrar;
            accionCliente.ShowDialog();
        }

        private void AccionCerrar(object sender, FormClosedEventArgs e)
        {
            Listar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.DataSource = ControllerPersona.BuscarClientes(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros que se puedan editar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AccionCliente accionCliente = new AccionCliente("Editar cliente",dgvClientes.CurrentRow.Cells[0].Value.ToString(), dgvClientes.CurrentRow.Cells[2].Value.ToString(),
                                                            dgvClientes.CurrentRow.Cells[3].Value.ToString(), dgvClientes.CurrentRow.Cells[4].Value.ToString(),
                                                            dgvClientes.CurrentRow.Cells[5].Value.ToString(), dgvClientes.CurrentRow.Cells[6].Value.ToString(),
                                                            dgvClientes.CurrentRow.Cells[7].Value.ToString(), dgvClientes.CurrentRow.Cells[9].Value.ToString(),
                                                            dgvClientes.CurrentRow.Cells[8].Value.ToString());
            accionCliente.FormClosed += AccionCerrar;
            accionCliente.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvClientes.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var respuesta = MessageBox.Show("Seguro que quiere eliminar este cliente", "Sistema Mypo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var resultado = ControllerPersona.Eliminar(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString()));
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
