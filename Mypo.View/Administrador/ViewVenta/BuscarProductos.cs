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

namespace Mypo.View.Administrador.ViewVenta
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
                dgvProductos.DataSource = ControllerProducto.Listar();
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace,"Sistema Mypo");
            }
        }

        private void AjustarTabla()
        {
            var celda_imagen = dgvProductos.Columns[8] as DataGridViewImageColumn;

            celda_imagen.Visible = false;

            for (int i = 0; i < dgvProductos.Columns.Count; i++)
            {
                dgvProductos.Columns[i].Width = 200;
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
            int idProducto;
            string codigo;
            string nombre;
            decimal costo;
            int stock;

            idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
            codigo = Convert.ToString(dgvProductos.CurrentRow.Cells[3].Value);
            nombre = Convert.ToString(dgvProductos.CurrentRow.Cells[4].Value);
            costo = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[5].Value);
            stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells[6].Value);

            DatosVenta.IDProducto = idProducto;
            DatosVenta.Codigo = codigo;
            DatosVenta.Nombre = nombre;
            DatosVenta.Costo = costo;
            DatosVenta.Stock = stock;

            this.Close();
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
                MessageBox.Show(ex.StackTrace, "Sistema Mypo");
            }
        }
    }
}
