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

namespace Mypo.View.Administrador.ViewCliente
{
    public partial class AccionCliente : Form
    {
        public AccionCliente(string accion)
        {
            InitializeComponent();
            lblAccion.Text = accion;
            txtID.Visible = false;
            lblId.Visible = false;
            chbEstado.Visible = false;
            this.Text = accion;
        }

        public AccionCliente(string accion,string id, string nombre, string p_a, string s_a, string curp, string rfc, string direccion, string email, string telefono/*, bool estado*/)
        {
            InitializeComponent();
            lblAccion.Text = accion;
            txtID.Text = id;
            txtNombre.Text = nombre;
            txtPrimerApellido.Text = p_a;
            txtSegundoApellido.Text = s_a;
            txtCURP.Text = curp;
            txtRFC.Text = rfc;
            txtDireccion.Text = rfc;
            txtEmail.Text = email;
            txtTelefono.Text = telefono;
            chbEstado.Visible = false;
            this.Text = accion;
            /* chbEstado.Checked = estado;


             if(chbEstado.Checked is true)
             {
                 chbEstado.Text = "Este cliente se encuentra activo";
             }
             else
             {
                 chbEstado.Text = "Este cliente se encuentra activo";
             }*/

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = null;

                if (txtNombre.Text is "" || txtPrimerApellido.Text is "")
                {
                    MessageBox.Show("Falta completar algunos campos", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtID.Text.Trim().Length > 0)
                {
                    respuesta = ControllerPersona.Actualizar(Convert.ToInt32(txtID.Text),"Cliente",txtNombre.Text,txtPrimerApellido.Text,txtSegundoApellido.Text,
                        txtNombre.Text,txtPrimerApellido.Text,txtSegundoApellido.Text,txtCURP.Text,txtRFC.Text,txtDireccion.Text,txtTelefono.Text,txtEmail.Text);
                }
                else
                {
                    respuesta = ControllerPersona.Insertar("Cliente", txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text,
                                                            txtCURP.Text, txtRFC.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
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
                MessageBox.Show(ex.ToString(),"Sistema Mypo");
            }
        }
    }
}
