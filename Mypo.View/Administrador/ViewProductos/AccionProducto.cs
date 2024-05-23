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
using BarcodeLib;

namespace Mypo.View.Administrador.ViewProductos
{
    public partial class AccionProducto : Form
    {

        DataTable dtReceta = null;

        public AccionProducto(string accion,bool lblVisible,bool txtIdVisible)
        {
            InitializeComponent();
            ListarCategorias();
            lblAccion.Text = accion;
            lblID.Visible = lblVisible;
            txtID.Visible = txtIdVisible;
            chbEstado.Visible = false;
            picbFoto.Image = Image.FromFile("..\\..\\Resources\\sushi.png");
            this.Text = accion;
        }

        public AccionProducto(string accion,string id, string idCategoria,string codigo, string nombre,string precioNeto, string stock,string descripcion,
            Image imagen,bool estado)
        {
            InitializeComponent();
            ListarCategorias();
            lblReceta.Visible = false;
            btnAgregarReceta.Visible = false;
            lblAccion.Text = accion;
            txtID.Text = id;
            cmbCategoria.SelectedValue = idCategoria;
            txtUPC.Text = codigo;
            txtNombre.Text = nombre;
            txtPrecioNeto.Text = precioNeto;
            txtStock.Text = stock;
            txtDescripcion.Text = descripcion;
            picbFoto.Image = imagen;
            chbEstado.Checked = estado;
            this.Text = accion;

            if (codigo != "")
            {
                GenerarCodigoDeBarras();
            }

            if(chbEstado.Checked is true)
            {
                chbEstado.Text = "Este producto se encuentra activo";
            }
            else
            {
                chbEstado.Text = "Este producto se encuentra inactivo";
            }
        }

        private void ListarCategorias()
        {
            try
            {
                cmbCategoria.DataSource = ControllerProducto.ListarCategorias();
                cmbCategoria.ValueMember = "idcategoria";
                cmbCategoria.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Systema Mypo");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionarImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Archivos de imagen (*.jpg, *.png, *.jpeg) | *.jpg; *.png; *.jpeg)";

                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    picbFoto.Image = Image.FromFile(fileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Sistema Mypo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text is "" || txtStock.Text is "" || txtPrecioNeto.Text is "" || txtStock.Text is "")
                {
                    MessageBox.Show("Falta completar algunos campos","Sistema Mypo");
                    return;
                }

                if(picbFoto.Image is null)
                {
                    MessageBox.Show("Seleccione una imagen para este producto","Sistema Mypo");
                    return;
                }

                int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                Image imagen = picbFoto.Image;
                decimal precio = Convert.ToDecimal(txtPrecioNeto.Text);
                int stock = Convert.ToInt32(txtStock.Text);

                string respuesta = null;


                if (txtID.Text.Trim().Length > 0)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    EditarEstadoProducto();
                    respuesta = ControllerProducto.Actualizar(id,idCategoria,"",txtUPC.Text,txtNombre.Text,precio,stock,txtDescripcion.Text,imagen);
                }
                else
                {
                    respuesta = ControllerProducto.Insertar(idCategoria,txtUPC.Text,txtNombre.Text,precio,stock,txtDescripcion.Text,imagen,dtReceta);
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

        private void btnGenerarCodigoBarra_Click(object sender, EventArgs e)
        {
            GenerarCodigoDeBarras();
        }

        private void EditarEstadoProducto()
        {
            if (chbEstado.Visible == true)
            {
                if (chbEstado.Checked == true)
                {
                    ControllerProducto.Activar(Convert.ToInt32(txtID.Text));
                }
                else
                {
                    ControllerProducto.Desactivar(Convert.ToInt32(txtID.Text));
                }
            }
        }

        private void GenerarCodigoDeBarras()
        {
            try
            {
                Barcode barcode = new Barcode();
                picbCodigo.Image = barcode.Encode(TYPE.CODE128, txtUPC.Text, Color.Black, Color.White, 400, 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sistema Mypo");
            }
        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
            Recetario recetario = new Recetario();
            recetario.FormClosed += CerrarRecetario;
            recetario.ShowDialog();
        }

        private void CerrarRecetario(object sender, FormClosedEventArgs e)
        {
            this.dtReceta = DetalleProducto.Detalle;
        }
    }
}
