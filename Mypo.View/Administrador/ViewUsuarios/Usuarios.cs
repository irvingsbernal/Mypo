using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Mypo.Controller;

namespace Mypo.View.Administrador.ViewUsuarios
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dgvUsuarios.DataSource = ControllerUsuario.Listar();
                lblTotal.Text = "Usuarios registrados: " +dgvUsuarios.Rows.Count;
                AjustarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Sitema Mypo");
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

        private void AjustarTabla()
        {
            var columnaFoto = dgvUsuarios.Columns[11] as DataGridViewImageColumn;
            columnaFoto.Visible = false;

            for (int i = 0; i < dgvUsuarios.Columns.Count; i++)
            {
                dgvUsuarios.Columns[i].Width = 150;
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccionUsuario accionUsuario = new AccionUsuario("Agregar usuario");
            accionUsuario.FormClosed += CerrarAccion;
            accionUsuario.ShowDialog();
        }

        private void CerrarAccion(object sender,FormClosedEventArgs e)
        {
            Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros que se puedan editar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            string idRol = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            string nombre = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            string p_a = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            string s_a = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            string nss = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            string rfc = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
            string dir = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
            string tel = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();
            string email = dgvUsuarios.CurrentRow.Cells[10].Value.ToString();
            bool estado = Convert.ToBoolean(dgvUsuarios.CurrentRow.Cells[12].Value);

            Image foto = null;

            if(dgvUsuarios.CurrentRow.Cells[11].Value != DBNull.Value)
            {
                MemoryStream ms = new MemoryStream((byte[])dgvUsuarios.CurrentRow.Cells[11].Value);
                foto = Image.FromStream(ms);
            }
            else
            {
                foto = Image.FromFile("..\\..\\Resources\\profile_avatar.png");
            }

            AccionUsuario accionUsuario = new AccionUsuario("Editar usuario",id,idRol,nombre,p_a,s_a,nss,rfc,tel,dir,email,estado,foto);
            accionUsuario.FormClosed += CerrarAccion;
            accionUsuario.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.DataSource = ControllerUsuario.Buscar(txtBuscar.Text);
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
                if (dgvUsuarios.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var respuesta = MessageBox.Show("Seguro que quiere eliminar este registro", "Sistema Mypo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var resultado = ControllerUsuario.Eliminar(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value.ToString()));
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
