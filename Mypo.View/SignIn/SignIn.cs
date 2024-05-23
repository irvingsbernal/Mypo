using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mypo.View;
using Mypo.Model;
using Mypo.Controller;
using Mypo.View.Administrador;

namespace Mypo.View.SignIn
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

            if (txtValor.Text.Equals(""))
            {
                txtValor.Text = "Usuario o correo electronico";
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text.Equals(""))
            {
                txtContrasenia.Text = "Contraseña";
                txtContrasenia.ForeColor = Color.White;
                txtContrasenia.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtValor.Clear();

            txtContrasenia.Clear();

            txtValor.Text = "Usuario o correo electronico";

            txtContrasenia.Text = "Contraseña";

            txtContrasenia.ForeColor = Color.White;

            txtContrasenia.UseSystemPasswordChar = false;

            lblMsg.Visible = false;

            this.Show();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtValor.Text.Equals("Usuario o correo electronico"))
            {
                txtValor.Text = "";
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text.Equals("Contraseña"))
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.Gold;
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void Login()
        {
            try
            {
                if (txtValor.Text.Equals("Usuario o correo electronico") || txtContrasenia.Text.Equals("Contraseña"))
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Ingrese sus datos de usuario.";
                    return;
                }

                ControllerLogin login = new ControllerLogin();

                if (login.Login(txtValor.Text, txtContrasenia.Text))
                {
                    this.Hide();

                    Bienvenida bienvenida = new Bienvenida();
                    bienvenida.ShowDialog();
                    
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        dashboard.FormClosed += Logout;
                    

                }
                else
                {
                    lblMsg.Visible = true;

                    lblMsg.Text = "Los datos de la credencial son incorrectos \n"+"o se encuentran inactivos";

                    txtValor.Text = "Usuario";

                    txtContrasenia.Text = "Contraseña";

                    txtContrasenia.ForeColor = Color.White;

                    txtContrasenia.UseSystemPasswordChar = false;

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Systema Mypo");
            }
        }

        private void OnEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Login();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Login();
        }
    }
}