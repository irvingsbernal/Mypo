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

namespace Mypo.View.Administrador.ViewIngreso
{
    public partial class AccionIngreso : Form
    {

        DataTable dtDetalle = new DataTable();

        public AccionIngreso(string accion)
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
            BuscarProveedor buscarProveedor = new BuscarProveedor();
            buscarProveedor.FormClosed += CerrarBuscadorProveedor;
            buscarProveedor.ShowDialog();
        }

        private void CalcularEmbarque()
        {
            decimal total = 0;
            decimal subtotal = 0;
            if (dtDetalle.Rows.Count == 0)
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


        private void CerrarBuscadorProveedor(object sender, FormClosedEventArgs e)
        {
            this.txtIDProveedor.Text = DatosIngreso.IDProveedor;
            this.txtNombreProveedor.Text = DatosIngreso.NombreProveedor;
        }

        private void GenerarDetalle()
        {

            dtDetalle.Columns.Add("ID", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("Código", System.Type.GetType("System.String"));
            dtDetalle.Columns.Add("Piezas", System.Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));

            dtDetalle.Columns.Add("Precio", System.Type.GetType("System.Decimal"));
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
                    var piezas = Interaction.InputBox("¿Cuantas piezas se van a ingresar?", "Sistema Mypo");

                    if (Convert.ToInt32(piezas) < 0)
                    {
                        MensajeError("Entrada invalida de piezas");
                        piezas = 1.ToString();
                    }
                    DataRow row = dtDetalle.NewRow();
                    row["ID"] = DatosIngreso.IDProducto;
                    row["Producto"] = DatosIngreso.Nombre;
                    row["Código"] = DatosIngreso.Codigo;

                    row["Piezas"] = piezas;
                    row["Cantidad"] = piezas;
                    row["Precio"] = DatosIngreso.Costo;
                    decimal precio = Convert.ToDecimal(row["Precio"]);
                    int cantidad = Convert.ToInt32(row["Piezas"]);
                    row["Importe"] = precio * cantidad;
                    dtDetalle.Rows.Add(row);
                    CalcularEmbarque();
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
                if (txtIDProveedor.Text == string.Empty || txtNombreProveedor.Text == string.Empty ||
                    txtLicencia.Text == string.Empty)
                {
                    MensajeError("Falta completar algunos campos.");
                    return;
                }
                if(dgvDetalle.Rows.Count == 0)
                {
                    MensajeError("El ingreso debe contener al menos un producto");
                    return;
                }
                else
                {
                    response = ControllerIngreso.Insertar(Convert.ToInt32(txtIDProveedor.Text.Trim()), Cache.Id,
                                                          cmbDocumento.Text, txtFolio.Text.Trim(), txtLicencia.Text,
                                                          Convert.ToDecimal(txtImpuesto.Text.Trim()), Convert.ToDecimal(txtTotal.Text.Trim()),
                                                          dtDetalle);
                    if (response.Equals("Ok"))
                    {
                        MensajeOk("¡Embarque ingresado con éxito!");
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
            decimal precio = Convert.ToDecimal(fila["Precio"]);
            int cantidad = Convert.ToInt32(fila["Piezas"]);

            if(cantidad < 0)
            {
                MensajeError("Ingreso invalido de cantidad");
                fila["Piezas"] = 1;
                fila["Cantidad"] = 1;
                cantidad = 1;
            }
            fila["Importe"] = precio * cantidad;
            CalcularEmbarque();
        }
    }
    }