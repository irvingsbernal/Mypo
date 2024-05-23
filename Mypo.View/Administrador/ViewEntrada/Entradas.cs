using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mypo.Controller;

namespace Mypo.View.Administrador.ViewEntrada
{
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dgvEntradas.DataSource = ControllerEmbarque.Listar();
                lblTotal.Text = "Entradas registradas: " + (dgvEntradas.Rows.Count);
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Systema Mypo");
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccionEntrada accionEmbarque = new AccionEntrada("Agregar datos de entrada", false, false);
            accionEmbarque.FormClosed += CerrarAccion;
            accionEmbarque.ShowDialog();
        }

        private void Embarques_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void CerrarAccion(object sender, FormClosedEventArgs e)
        {
            Listar();
        }

        private void AjustarTabla()
        {
            var celda_Imagen = dgvEntradas.Columns[8] as DataGridViewImageColumn;
            celda_Imagen.Visible = false;

            for (int i = 0; i < dgvEntradas.Columns.Count; i++)
            {
                dgvEntradas.Columns[i].Width = 200;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEntradas.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros que se puedan editar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dgvEntradas.CurrentRow.Cells[0].Value.ToString();
            string idCategoria = dgvEntradas.CurrentRow.Cells[1].Value.ToString();
            string codigo = dgvEntradas.CurrentRow.Cells[3].Value.ToString();
            string nombre = dgvEntradas.CurrentRow.Cells[4].Value.ToString();
            string costo = dgvEntradas.CurrentRow.Cells[5].Value.ToString();
            string stock = dgvEntradas.CurrentRow.Cells[6].Value.ToString();
            string descripcion = dgvEntradas.CurrentRow.Cells[7].Value.ToString();
            bool estado = Convert.ToBoolean(dgvEntradas.CurrentRow.Cells[9].Value);

            Image imagen = null;
            if (dgvEntradas.CurrentRow.Cells[8].Value != DBNull.Value)
            {
                MemoryStream ms = new MemoryStream((byte[])dgvEntradas.CurrentRow.Cells[8].Value);
                imagen = Image.FromStream(ms);
            }
            else
            {
                imagen = Image.FromFile("..\\..\\Resources\\product.png");
            }

            AccionEntrada accionEmbarque = new AccionEntrada("Editar datos de entrada",id,idCategoria,nombre,codigo,costo,stock,descripcion,imagen,estado);
            accionEmbarque.FormClosed += CerrarAccion;
            accionEmbarque.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvEntradas.DataSource = ControllerEmbarque.Buscar(txtBuscar.Text);
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
                if (dgvEntradas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var respuesta = MessageBox.Show("Seguro que quiere eliminar este registro", "Sistema Mypo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var resultado = ControllerEmbarque.Eliminar(Convert.ToInt32(dgvEntradas.CurrentRow.Cells[0].Value.ToString()));
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
