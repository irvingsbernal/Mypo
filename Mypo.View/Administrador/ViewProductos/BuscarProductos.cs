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
using Mypo.Model;

namespace Mypo.View.Administrador.ViewProductos
{
    public partial class BuscarProductos : Form
    {
        public BuscarProductos()
        {
            InitializeComponent();
        }


        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text.Equals(""))
            {
                this.txtBuscar.Text = "Filtro de busqueda";
                ListarProductos();
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text.Equals("Filtro de busqueda"))
            {
                this.txtBuscar.Text = "";
            }
        }

        private void ListarProductos()
        {
            try
            {
                dgvProductos.DataSource = ControllerEmbarque.Listar();
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace,"Sistema Mypo");
            }
        }

        private void AjustarTabla()
        {
            for (int i = 0; i < dgvProductos.Columns.Count; i++)
            {
                dgvProductos.Columns[i].Width = 150;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.DataSource = ControllerEmbarque.Buscar(txtBuscar.Text);
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema Mypo");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ListarProductos();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
            int stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells[6].Value);
            string nombre = Convert.ToString(dgvProductos.CurrentRow.Cells[4].Value);

            DetalleProducto.IDProducto = idProducto;
            DetalleProducto.Nombre = nombre;
            DetalleProducto.Stock = stock;
            this.Close();
        }

    }
}
