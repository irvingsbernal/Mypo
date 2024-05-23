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


namespace Mypo.View.Administrador.ViewRoles
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dgvRoles.DataSource = ControllerRol.Listar();
                dgvRoles.Columns[1].Width = 300;
                dgvRoles.Columns[2].Width = 300;
                lblTotal.Text = "Roles registrados: " + dgvRoles.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Sistema Mypo");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccionRol accionRol = new AccionRol("Agregar rol de usuario");
            accionRol.FormClosed += AccionCerrar;
            accionRol.ShowDialog();
        }

        private void AccionCerrar(object sender, FormClosedEventArgs e)
        {
            Listar();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros que se puedan editar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AccionRol accionRol = new AccionRol("Editar rol de usuario",dgvRoles.CurrentRow.Cells[0].Value.ToString(), dgvRoles.CurrentRow.Cells[1].Value.ToString(),
                dgvRoles.CurrentRow.Cells[2].Value.ToString(),Convert.ToBoolean(dgvRoles.CurrentRow.Cells[3].Value.ToString()));
            accionRol.FormClosed += AccionCerrar;
            accionRol.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoles.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var respuesta = MessageBox.Show("Seguro que quiere eliminar este rol", "Sistema Mypo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var resultado = ControllerRol.Eliminar(Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show(resultado, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvRoles.DataSource = ControllerRol.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text.Equals("Filtro de busqueda"))
            {
                this.txtBuscar.Text = "";
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
    }
}
