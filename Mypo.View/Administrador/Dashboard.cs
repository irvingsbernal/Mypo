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
using Mypo.View.Administrador.ViewCategoria;
using Mypo.View.Administrador.ViewProductos;
using Mypo.View.Administrador.ViewEntrada;
using Mypo.View.Administrador.ViewUsuarios;
using Mypo.View.Administrador.ViewRoles;
using Mypo.View.Administrador.ViewCliente;
using Mypo.View.Administrador.ViewProveedor;
using Mypo.View.Administrador.ViewPreventa;
using Mypo.View.Administrador.ViewIngreso;
using Mypo.View.Administrador.ViewVenta;
using Mypo.View.Administrador.ViewReporteVentas;

namespace Mypo.View.Administrador
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            if(Cache.Estado == 0)
            {
                MessageBox.Show("Sus credennciales de usuario estan inactivas","Sistema Mypo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();
            }
        }


        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            switch (Cache.IdRol)
            {
                /*Rol administrador*/
                case 1:
                    btnInventario.Visible = true;
                    btnReportes.Visible = true;
                    btnAutenticacion.Visible = true;
                    btnEmbarques.Visible = true;
                    btnVentas.Visible = true;
                    btnInventario.Enabled = true;
                    btnReportes.Enabled = true;
                    btnAutenticacion.Enabled = true;
                    btnEmbarques.Enabled = true;
                    btnVentas.Enabled = true;
                    break;
                /*Rol almacenista*/
                case 2:
                    btnInventario.Visible = true;
                    btnReportes.Visible = false;
                    btnAutenticacion.Visible = false;
                    btnEmbarques.Visible = false;
                    btnVentas.Visible = false;
                    btnInventario.Enabled = true;
                    btnReportes.Enabled = false;
                    btnAutenticacion.Enabled = false;
                    btnEmbarques.Enabled = false;
                    btnVentas.Enabled = false;
                    break;
                /*Rol promotor*/
                case 3:
                    btnInventario.Visible = false;
                    btnReportes.Visible = true;
                    btnAutenticacion.Visible = false;
                    btnEmbarques.Visible = false;
                    btnVentas.Visible = true;
                    btnInventario.Enabled = false;
                    btnReportes.Enabled = false;
                    btnAutenticacion.Enabled = false;
                    btnEmbarques.Enabled = false;
                    btnVentas.Enabled = true;
                    break;
            }

            CargarModulo(new Preventa());

            this.btnNormal.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            this.lblNombre.Text = Cache.Nombre + " " + Cache.Primer_Apellido + " " + Cache.Segundo_Apellido;
            this.picbFoto.Image = Cache.Foto;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var cerrar = MessageBox.Show("¿Seguro que quiere cerrar la aplicación?", "Sistema Mypo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.btnMaximizar.Visible = false;
            this.btnNormal.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btnMaximizar.Visible = true;
            this.btnNormal.Visible = false;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var signout = MessageBox.Show("¿Seguro que quiere cerrar sesion?", "Sistema Mypo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (signout == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.pnlSubMnuInventario.Visible = !this.pnlSubMnuInventario.Visible;
        }

        private void CargarModulo(object modulo)
        {
            if (this.pnlModulo.Controls.Count > 0)
                    this.pnlModulo.Controls.RemoveAt(0);

                Form form = modulo as Form;

                form.TopLevel = false;

                form.FormBorderStyle = FormBorderStyle.None;

                form.Dock = DockStyle.Fill;

                this.pnlModulo.Controls.Add(form);

                this.pnlModulo.Tag = form;

                form.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CargarModulo(new Categorias());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(this.pnlMenu.Width == 55)
            {
                pnlMenu.Visible = false;
                pnlMenu.Width = 230;
                MostrarEtiquetas();
                TransicionMenu.ShowSync(pnlMenu);
            }
            else
            {
                pnlMenu.Visible = false;
                pnlMenu.Width = 55;
                OcultarEtiquetas();
                TransicionMenu.ShowSync(pnlMenu);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CargarModulo(new Productos());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CargarModulo(new Usuarios());
        }

        private void MostrarEtiquetas()
        {
            btnInicio.Text = "Inicio";
            btnInventario.Text = "Inventario";
            btnCategoria.Text = "Categorias";
            btnEntradas.Text = "Entradas";
            btnProductos.Text = "Productos";
            btnReportes.Text = "Ventas";
            btnAutenticacion.Text = "Autenticación";
            btnRoles.Text = "Roles";
            btnUsuarios.Text = "Usuarios";
            btnReportes.Text = "Reportes";
            btnReportesVentas.Text = "Ventas";
            btnReportesOrdenes.Text = "Ordenes";
            btnEmbarques.Text = "Embarques";
            btnOrdenes.Text = "Ordenes";
            btnProveedores.Text = "Proveedores";
            btnVentas.Text = "Ventas";
            btnClientes.Text = "Clientes";
            btnRegistros.Text = "Registros";
        }

        private void OcultarEtiquetas()
        {
            btnInicio.Text = "";
            btnInventario.Text = "";
            btnCategoria.Text = "";
            btnProductos.Text = "";
            btnEntradas.Text = "";
            btnReportes.Text = "";
            btnAutenticacion.Text = "";
            btnRoles.Text = "";
            btnUsuarios.Text = "";
            btnReportes.Text = "";
            btnReportesVentas.Text = "";
            btnReportesOrdenes.Text = "";
            btnEmbarques.Text = "";
            btnOrdenes.Text = "";
            btnProveedores.Text = "";
            btnVentas.Text = "";
            btnClientes.Text = "";
            btnRegistros.Text = "";
        }

        private void btnAutenticacion_Click(object sender, EventArgs e)
        {
            this.pnlSubMnuAutenticacion.Visible = !this.pnlSubMnuAutenticacion.Visible;
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            CargarModulo(new Roles());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.pnlSubMnuReportes.Visible = !this.pnlSubMnuReportes.Visible;
        }

        private void btnEmbarques_Click(object sender, EventArgs e)
        {
            this.pnlSubMnuEmbarques.Visible = !this.pnlSubMnuEmbarques.Visible;
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            CargarModulo(new Entradas());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.pnlSubMnuVentas.Visible = !this.pnlSubMnuVentas.Visible;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CargarModulo(new Clientes());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            CargarModulo(new Proveedores());
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            CargarModulo(new Ingresos());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CargarModulo(new Preventa());
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            CargarModulo(new Ventas());
        }

        private void btnReportesVentas_Click(object sender, EventArgs e)
        {
            CargarModulo(new ReporteVentas());
        }
    }
}
