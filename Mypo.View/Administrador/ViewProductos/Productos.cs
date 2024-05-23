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
using System.IO;

namespace Mypo.View.Administrador.ViewProductos
{
    public partial class Productos : Form
    {
        public Productos()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var accionProducto = new AccionProducto("Agregar producto",false,false);
            accionProducto.FormClosed += CerrarAccion;
            accionProducto.ShowDialog();
        }

        private void Listar()
        {
            try
            {
                dgvProductos.DataSource = ControllerProducto.Listar();
                lblTotal.Text = "Productos registrados: " + dgvProductos.Rows.Count;
                AjustarTabla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sistema Mypo");
            }
        }

        private void AjustarTabla()
        {
            dgvProductos.Columns[8].Visible = false;

            for (int i = 0; i < dgvProductos.Columns.Count; i++)
            {
                dgvProductos.Columns[i].Width = 200;
            }

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Listar();           
        }

        private void CerrarAccion(object sender, FormClosedEventArgs e)
        {
            Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros que se puedan editar", "Sistema Mypo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            /*Convertir datos de la fila seleccionada del DataGridView*/

            string id = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            string idCategoria = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            string codigo = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            string nombre = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            string precioNeto = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            string stock = dgvProductos.CurrentRow.Cells[6].Value.ToString();
            string descripcion = dgvProductos.CurrentRow.Cells[7].Value.ToString();
            bool estado = Convert.ToBoolean(dgvProductos.CurrentRow.Cells[9].Value);

            Image imagen = null;
            if(dgvProductos.CurrentRow.Cells[8].Value != DBNull.Value)
            {
                MemoryStream ms = new MemoryStream((byte[])dgvProductos.CurrentRow.Cells[8].Value);
                imagen = Image.FromStream(ms);
            }
            else
            {
                imagen = Image.FromFile("..\\..\\Resources\\sushi.png");
            }



            var accionProducto = new AccionProducto("Editar producto", id,idCategoria,codigo,nombre,precioNeto,stock,descripcion,imagen,estado);
            accionProducto.FormClosed += CerrarAccion;
            accionProducto.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.DataSource = ControllerProducto.Buscar(txtBuscar.Text);
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
                if (dgvProductos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var respuesta = MessageBox.Show("Seguro que quiere eliminar este registro", "Sistema Mypo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var resultado = ControllerProducto.Eliminar(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show(resultado, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var datos = ControllerProducto.VerDetalle(Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value));

                DetalleDeProducto dt = new DetalleDeProducto(datos);
                dt.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
