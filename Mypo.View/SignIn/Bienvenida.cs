using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mypo.Model;

namespace Mypo.View.SignIn
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1)
            
                this.Opacity += 0.05;
                pgbCarga.Value += 1;

            lblMsg.Text = pgbCarga.Value + "%   Cargando...";

            if (pgbCarga.Value == 100)
            {
                timerFadeIn.Stop();
                timerFadeOut.Start();
            }
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if(this.Opacity == 0)
            {
                timerFadeOut.Stop();
                this.Close();
            }
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text =  "Bienvenido, a accedido como:";

            lblUsuario.Text = Cache.Nombre + " " + Cache.Primer_Apellido;

            this.Opacity = 0;

            timerFadeIn.Start();
        }
    }
}
