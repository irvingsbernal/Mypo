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

namespace Mypo.View.Administrador.ViewIngreso
{
    public partial class BuscarProveedor : Form
    {
        public BuscarProveedor()
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Listar();
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DatosIngreso.IDProveedor = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            DatosIngreso.NombreProveedor = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProveedores.DataSource = ControllerPersona.BuscarProveedores(txtBuscar.Text);
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Systema Mypo");
            }
        }
    }
}
