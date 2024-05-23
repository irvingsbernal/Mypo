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

namespace Mypo.View.Administrador.ViewCategoria
{
    public partial class Categorias : Form
    {
        public Categorias()
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
                dgvCategorias.DataSource = ControllerCategoria.Listar();
                lblTotal.Text = "Categorias registradas: " + (dgvCategorias.Rows.Count);

                dgvCategorias.Columns[1].Width = 200;
                dgvCategorias.Columns[2].Width = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Systema Mypo");
            }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccionCategoria form = new AccionCategoria("Agregar categoria",false,false);
            form.FormClosed += CerrarAccion;
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros que se puedan editar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AccionCategoria form = new AccionCategoria(dgvCategorias.CurrentRow.Cells[0].Value.ToString(),
            dgvCategorias.CurrentRow.Cells[1].Value.ToString(), dgvCategorias.CurrentRow.Cells[2].Value.ToString(), "Editar categoria",
            Convert.ToBoolean(dgvCategorias.CurrentRow.Cells[3].Value));
            form.FormClosed += CerrarAccion;
            form.ShowDialog();

        }

        /*Este metodo se sobrecarga al evento FormClosed cuando se cierra el formulario para agregar o editar*/
        private void CerrarAccion(object sender,FormClosedEventArgs e)
        {
            this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBuscar.Text == "Filtro de busqueda" || txtBuscar.Text == "")
                {
                    MessageBox.Show("Ingresa un valor de busqueda","Sistema Mypo");
                    return;
                }
                dgvCategorias.DataSource = ControllerCategoria.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Sistema Mypo");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var respuesta = MessageBox.Show("Seguro que quiere eliminar esta categoria", "Sistema Mypo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(respuesta == DialogResult.Yes)
                {
                    var resultado = ControllerCategoria.Eliminar(Convert.ToInt32(dgvCategorias.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show(resultado,"Sistema Mypo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Listar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Sistema Mypo");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCategorias.DataSource = ControllerCategoria.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Sistema Mypo");
            }
        }
    }
}
