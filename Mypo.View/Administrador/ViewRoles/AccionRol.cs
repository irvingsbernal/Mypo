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
    public partial class AccionRol : Form
    {
        public AccionRol(string accion)
        {
            InitializeComponent();
            lblAccion.Text = accion;
            lblId.Visible = false;
            txtID.Visible = false;
            chbEstado.Visible = false;
            this.Text = accion;
        }

        public AccionRol(string accion,string id,string nombre,string descripcion,bool estado)
        {
            InitializeComponent();
            lblAccion.Text = accion;

            txtID.Text = id;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            chbEstado.Checked = estado;
            this.Text = accion;

            if (chbEstado.Checked is true)
            {
                chbEstado.Text = "Este rol de usuario se encuentra activo";
            }
            else
            {
                chbEstado.Text = "Este rol de usuario se encuentra activo";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarEstadoRol()
        {
            if (chbEstado.Visible == true)
            {
                if (chbEstado.Checked == true)
                {
                    ControllerRol.Activar(Convert.ToInt32(txtID.Text));
                }
                else
                {
                    ControllerRol.Desactivar(Convert.ToInt32(txtID.Text));
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = null;

                if (txtID.Text.Trim().Length > 0)
                {
                    EditarEstadoRol();
                    respuesta = ControllerRol.Actualizar(Convert.ToInt32(txtID.Text), "", txtNombre.Text, txtDescripcion.Text);
                }
                else
                {
                    respuesta = ControllerRol.Insertar(txtNombre.Text, txtDescripcion.Text);
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
                MessageBox.Show("Ocurrio el siguiente error: " + ex.ToString(), "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
