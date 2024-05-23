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
using BarcodeLib;

namespace Mypo.View.Administrador.ViewEntrada
{
    public partial class AccionEntrada : Form
    {
        public AccionEntrada(string accion,bool lblVisible, bool txtIDvisible)
        {
            InitializeComponent();
            this.lblAccion.Text = accion;
            this.lblID.Visible = lblVisible;
            this.txtID.Visible = txtIDvisible;
            this.Text = accion;

            picbFoto.Image = Image.FromFile("..\\..\\Resources\\product.png");
            ListarCategorias();

            this.txtNombre.Focus();

            this.chbEstado.Visible = false;
        }

        public AccionEntrada(string accion,string id, string idcategoria,string nombre,string upc,string costo,string stock, string descripcion,
            Image imagen,bool estado)
        {
            InitializeComponent();
            this.lblAccion.Text = accion;
            ListarCategorias();
            this.txtID.Text = id;
            this.cmbCategoria.SelectedValue = idcategoria;
            this.txtNombre.Text = nombre;
            this.txtUPC.Text = upc;
            this.txtCosto.Text = costo;
            this.txtStock.Text = stock;
            this.txtDescripcion.Text = descripcion;
            this.picbFoto.Image = imagen;
            this.chbEstado.Checked = estado;
            this.Text = accion;

            if (chbEstado.Checked == true)
            {
                chbEstado.Text = "Este registro de entrada esta activo";
            }
            else
            {
                chbEstado.Text = "Este registro de entrada esta inactivo";
            }

            if(upc != null)
            {
                GenerarCodigoDeBarras();
            }
           
        }


        private void ListarCategorias()
        {
            try
            {
                cmbCategoria.DataSource = ControllerEmbarque.ListarCategorias();
                cmbCategoria.ValueMember = "idcategoria";
                cmbCategoria.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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
                string nombreAnterior = txtNombre.Text;


                if (txtNombre.Text is "" || txtUPC.Text is "" || txtStock.Text is "" || txtCosto.Text is "")
                {
                    MessageBox.Show("Falta completar algunos campos","Sistema Mypo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                if (txtID.Text.Trim().Length > 0)
                {
                    EditarEstadoEntrada();
                    respuesta = ControllerEmbarque.Actualizar(Convert.ToInt32(txtID.Text),Convert.ToInt32(cmbCategoria.SelectedValue),nombreAnterior
                        , txtUPC.Text, txtNombre.Text, Convert.ToDecimal(txtCosto.Text), Convert.ToInt32(txtStock.Text), txtDescripcion.Text, picbFoto.Image);
                }
                else
                {
                    respuesta = ControllerEmbarque.Insertar(Convert.ToInt32(cmbCategoria.SelectedValue)
                        ,txtUPC.Text,txtNombre.Text,Convert.ToDecimal(txtCosto.Text),Convert.ToInt32(txtStock.Text),txtDescripcion.Text,picbFoto.Image);
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

        private void EditarEstadoEntrada()
        {
            if (chbEstado.Visible == true)
            {
                if (chbEstado.Checked == true)
                {
                    ControllerEmbarque.Activar(Convert.ToInt32(txtID.Text));
                }
                else
                {
                    ControllerEmbarque.Desactivar(Convert.ToInt32(txtID.Text));
                }
            }
        }

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            GenerarCodigoDeBarras();
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
