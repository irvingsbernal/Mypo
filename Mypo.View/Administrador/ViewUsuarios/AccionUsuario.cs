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


namespace Mypo.View.Administrador.ViewUsuarios
{
    public partial class AccionUsuario : Form
    {
        public AccionUsuario(string accion)
        {
            InitializeComponent();
            ListarRoles();
            lblAccion.Text = accion;
            txtID.Visible = false;
            lblID.Visible = false;
            chbEstado.Visible = false;
            picbFoto.Image = Image.FromFile("..\\..\\Resources\\profile_avatar.png");

            txtContrasenia.UseSystemPasswordChar = true;
            this.Text = accion;
        }

        public AccionUsuario(string accion,string id,string idrol,string nombre,string primer_apellido,string segundo_apellido, string nss,string rfc,
                             string telefono,string domicilio, string email,bool estado,Image foto)
        {
            InitializeComponent();
            ListarRoles();
            lblAccion.Text = accion;
            txtID.Text = id;
            cmbRol.SelectedValue = idrol;
            txtNombre.Text = nombre;
            txtPrimerApellido.Text = primer_apellido;
            txtSegundoApellido.Text = segundo_apellido;
            txtNSS.Text = nss;
            txtRFC.Text = rfc;
            txtTelefono.Text = telefono;
            txtEmail.Text = email;
            txtDomicilio.Text = domicilio;
            picbFoto.Image = foto;
            chbEstado.Checked = estado;
            txtContrasenia.UseSystemPasswordChar = true;
            this.Text = accion;

            if (chbEstado.Checked is true)
            {
                chbEstado.Text = "Este usuario esta activo";
            }
            else
            {
                chbEstado.Text = "Este usuario esta inactivo";
            }
        }


        private void ListarRoles()
        {
            try
            {
                cmbRol.DataSource = ControllerUsuario.ListarRoles();
                cmbRol.ValueMember = "idrol";
                cmbRol.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Systema Mypo");
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
                string respuesta = null;
                if (txtID.Text.Trim().Length > 0)
                {
                    EditarEstadoUsuario();
                    respuesta = ControllerUsuario.Actualizar(Convert.ToInt32(txtID.Text), Convert.ToInt32(cmbRol.SelectedValue),"", txtNombre.Text, txtPrimerApellido.Text,
                                                            txtSegundoApellido.Text,txtNSS.Text, txtRFC.Text, txtDomicilio.Text, txtTelefono.Text, txtEmail.Text,
                                                            txtContrasenia.Text, picbFoto.Image);
                }
                else
                {
                    respuesta = ControllerUsuario.Insertar(Convert.ToInt32(cmbRol.SelectedValue),txtNombre.Text,txtPrimerApellido.Text,txtSegundoApellido.Text,
                                                            txtNSS.Text,txtRFC.Text,txtDomicilio.Text,txtTelefono.Text,txtEmail.Text,txtContrasenia.Text,picbFoto.Image);
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
                MessageBox.Show(ex.ToString(), "Sistema Mypo");
            }
        }

        private void EditarEstadoUsuario()
        {
            if(chbEstado.Visible == true)
            {
                if(chbEstado.Checked == true)
                {
                    ControllerUsuario.Activar(Convert.ToInt32(txtID.Text));
                }
                else
                {
                    ControllerUsuario.Desactivar(Convert.ToInt32(txtID.Text));
                }
            }
        }

        private void btnSeleccionarImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Archivos de imagen (*.jpg, *.png, *.jpeg) | *.jpg; *.png; *.jpeg)";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    picbFoto.Image = Image.FromFile(fileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
