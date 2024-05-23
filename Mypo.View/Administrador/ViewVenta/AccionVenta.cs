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
using Mypo.Controller;
using Microsoft.VisualBasic;

namespace Mypo.View.Administrador.ViewVenta
{
    public partial class AccionVenta : Form
    {

        DataTable dtDetalle = new DataTable();

        public AccionVenta(string accion)
        {
            InitializeComponent();
            lblAccion.Text = accion;
            lblIDIngreso.Visible = false;
            txtID.Visible = false;
            this.Text = accion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente= new BuscarCliente();
            buscarCliente.FormClosed += CerrarBuscadorCliente;
            buscarCliente.ShowDialog();
        }

        private void CalcularVenta()
        {
            decimal total = 0;
            decimal subtotal = 0;
            if (dgvDetalle.Rows.Count == 0)
            {
                total = 0;
            }
            else
            {
                if (txtImpuesto.Text == string.Empty)
                {
                    MensajeError("Ingresa el impuesto a pagar, por cuestiones legales...");
                }
                else
                {
                    foreach (DataRow fila in dtDetalle.Rows)
                    {
                        total = total + Convert.ToDecimal(fila["Importe"]);

                    }

                }
                subtotal = total / (1 + Convert.ToDecimal(txtImpuesto.Text));
                txtTotal.Text = total.ToString("#0.00#");
                txtSubTotal.Text = subtotal.ToString("#0.00#");
                txtImpuestoTotal.Text = (total - subtotal).ToString("#0.00#");
            }

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            BuscarProductos buscarProductos = new BuscarProductos();
            buscarProductos.FormClosed += CerrarBuscadorProductos;
            buscarProductos.ShowDialog();
        }

        private void CerrarBuscadorProductos(object sender,FormClosedEventArgs e)
        {
            AgregarDetalle();
        }


        private void CerrarBuscadorCliente(object sender, FormClosedEventArgs e)
        {
            this.txtIDCliente.Text = DatosIngreso.IDProveedor;
            this.txtNombreCliente.Text = DatosIngreso.NombreProveedor;
        }

        private void GenerarDetalle()
        {
            dtDetalle.Columns.Add("ID", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Código", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("Precio Neto", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Stock", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Precio", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Importe", System.Type.GetType("System.Decimal"));

            dgvDetalle.DataSource = dtDetalle;

            for (int i = 0; i < dgvDetalle.Columns.Count; i++)
            {
                dgvDetalle.Columns[i].Width = 200;
            }
        }

        private void AgregarDetalle()
        {
            try
            {
                bool agregar = true;
                foreach (DataRow fila in dtDetalle.Rows)
                {
                    if (Convert.ToInt32(fila[0]) == DatosIngreso.IDProducto)
                    {
                        agregar = false;
                        MensajeError("Ya has agragado este producto....");
                    }
                }

                if (agregar)
                {
                    var piezas = Interaction.InputBox("¿Cuantas piezas de este producto seran vendidas?", "Sistema Mypo");

                    if (Convert.ToInt32(piezas) > DatosVenta.Stock)
                    {
                        MensajeError("La cantidad de venta del producto supera el stock....");
                        piezas = DatosVenta.Stock.ToString();
                    }


                    if (Convert.ToInt32(piezas) < 0)
                    {
                        MensajeError("Ingreso invalido de piezas");
                        piezas = 0.ToString();
                    }

                    DataRow row = dtDetalle.NewRow();
                    row["ID"] = DatosVenta.IDProducto;
                    row["Producto"] = DatosVenta.Nombre;
                    row["Código"] = DatosVenta.Codigo;

                    row["Cantidad"] = piezas;
                    row["Precio Neto"] = 0;

                    row["Stock"] = DatosVenta.Stock;
                    row["Precio"] = DatosVenta.Costo;
                    row["Descuento"] = 0;

                    decimal precioNeto = Convert.ToDecimal(row["Precio"]);
                    int cantidad = Convert.ToInt32(row["Cantidad"]);
                    decimal descuento = Convert.ToDecimal(row["Descuento"]);

                    row["Importe"] = (precioNeto * cantidad) - descuento;


                    dtDetalle.Rows.Add(row);

                    CalcularVenta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void AccionIngreso_Load(object sender, EventArgs e)
        {
            GenerarDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string response = "";
                if (txtIDCliente.Text == string.Empty || txtNombreCliente.Text == string.Empty ||
                    txtTicket.Text == string.Empty)
                {
                    MensajeError("Falta completar algunos campos.");
                    return;
                }
                if(dgvDetalle.Rows.Count == 0)
                {
                    MensajeError("La venta debe contener al menos un producto");
                    return;
                }
                else
                {
                    response = ControllerVenta.Insertar(Cache.Id, Convert.ToInt32(txtIDCliente.Text.Trim()),
                                                          txtTicket.Text, cmbDocumento.Text, txtFolio.Text.Trim(), 
                                                          Convert.ToDecimal(txtImpuesto.Text.Trim()), Convert.ToDecimal(txtTotal.Text.Trim()),
                                                          dtDetalle);
                    if (response.Equals("Ok"))
                    {
                        MensajeOk("¡Venta registrada con éxito!");
                        this.Close();
                    }
                    else
                    {
                        MensajeError(response);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow fila = (DataRow)dtDetalle.Rows[e.RowIndex];
            string producto = Convert.ToString(fila["Producto"]);
            int cantidad = Convert.ToInt32(fila["Cantidad"]);
            int stock = Convert.ToInt32(fila["Stock"]);
            decimal precioNeto = Convert.ToDecimal(fila["Precio"]);
            decimal descuento = Convert.ToDecimal(fila["Descuento"]);

            if (cantidad < 0)
            {
                MensajeError("Ingreso invalido de piezas");
                fila["Cantidad"] = 1;
                cantidad = 1;
            }

            if (cantidad > stock)
            {
                cantidad = stock;
                MensajeError("La cantidad de venta del producto supera el stock....");
                fila["Cantidad"] = cantidad;

            }
            fila["Importe"] = (precioNeto * cantidad) - descuento;
            CalcularVenta();
        }
    }
    }