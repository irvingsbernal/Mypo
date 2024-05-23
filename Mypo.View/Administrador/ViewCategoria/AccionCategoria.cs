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
    public partial class AccionCategoria : Form
    {

        public AccionCategoria(string accion,bool lblVisible,bool txtIdVisible)
        {
            InitializeComponent();
            this.lblAccion.Text = accion;
            lblId.Visible = lblVisible;
            txtID.Visible = txtIdVisible;
            this.chbEstado.Visible = false;
            this.Text = accion;
        }

        public AccionCategoria(string id, string nombre, string descripcion,string accion,bool estado)
        {
            InitializeComponent();
            this.lblAccion.Text = accion;
            this.txtID.Text = id;
            this.txtNombre.Text = nombre;
            this.txtDescripcion.Text = descripcion;
            this.chbEstado.Checked = estado;
            this.lblDescripcionEstado.Visible = true;
            this.Text = accion;

            if (this.chbEstado.Checked == true)
            {
                this.lblDescripcionEstado.Text = "Esta categoria se encuentra activa";
            }
            else
            {
                this.lblDescripcionEstado.Text = "Esta categoria se encuentra inactiva";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreAnterior = txtNombre.Text;
                string respuesta = null;

                if(txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Agregue un nombre de categoria","Sistema Mypo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

                if (txtID.Text.Trim().Length > 0)
                {
                    EditarEstadoCategoria();
                    respuesta = ControllerCategoria.Actualizar(Convert.ToInt32(txtID.Text), nombreAnterior,txtNombre.Text,txtDescripcion.Text);
                }
                else
                {
                    respuesta = ControllerCategoria.Insertar(txtNombre.Text, txtDescripcion.Text);
                }

                if (respuesta.Equals("Ok"))
                {
                    MessageBox.Show(respuesta, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(respuesta, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + ex.ToString(),"Sistema Mypo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void EditarEstadoCategoria()
        {
            if(chbEstado.Visible == true)
            {
                if (chbEstado.Checked == true)
                {
                    ControllerCategoria.Activar(Convert.ToInt32(txtID.Text));
                }
                else
                {
                    ControllerCategoria.Desactivar(Convert.ToInt32(txtID.Text));
                }
            }
        }
    }
}
