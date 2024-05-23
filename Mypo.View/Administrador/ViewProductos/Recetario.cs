using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Mypo.Model;

namespace Mypo.View.Administrador.ViewProductos
{
    public partial class Recetario : Form
    {

        public DataTable dtProducto = new DataTable();

        public Recetario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Se ha agregado todo lo necesario para este producto?","Sistema Mypo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarReceta();
        }

        private void GuardarReceta()
        {
            try
            {
                DetalleProducto.Detalle = dtProducto;
                if(DetalleProducto.Detalle.Rows.Count > 0)
                {
                    MessageBox.Show("Se ha guardado la informacion, prosigue a registrar el producto","Sistema Mypo");
                }
                else
                {
                    MessageBox.Show("Aun no se ha agregado informacion", "Sistema Mypo");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void AgregarDetalle()
        {
            try
            {
                bool agregar = true;
                foreach (DataRow fila in dtProducto.Rows)
                {
                    if (Convert.ToInt32(fila[0]) == DetalleProducto.IDProducto)
                    {
                        agregar = false;
                        MessageBox.Show("Ya has agragado este producto....", "Sistema Mypo");
                    }
                }

                if (agregar)
                {
                    var piezas = Interaction.InputBox("¿Cuantas piezas de este producto son necesarias?", "Sistema Mypo");

                    if (Convert.ToInt32(piezas) < 0)
                    {
                        MessageBox.Show("Ingreso invalido de piezas", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        piezas = 1.ToString();
                    }

                    if (Convert.ToInt32(piezas) > DetalleProducto.Stock)
                    {
                        MessageBox.Show("La cantidad ingresada sobrepasa el stock", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        piezas = 1.ToString();
                    }
                    DataRow row = dtProducto.NewRow();
                    row["ID"] = DetalleProducto.IDProducto;
                    row["Piezas"] = piezas;
                    row["Producto"] = DetalleProducto.Nombre;
                                                    
                    dtProducto.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CerrarBuscadorProductos(object sender, FormClosedEventArgs e)
        {
            AgregarDetalle();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProductos buscarProductos = new BuscarProductos();
            buscarProductos.FormClosed += CerrarBuscadorProductos;
            buscarProductos.ShowDialog();
        }

        private void GenerarDetalle()
        {

            dtProducto.Columns.Add("ID", System.Type.GetType("System.Int32"));
            dtProducto.Columns.Add("Producto", System.Type.GetType("System.String"));
            dtProducto.Columns.Add("Piezas", System.Type.GetType("System.Int32"));
            dtProducto.Columns.Add("Unidad", System.Type.GetType("System.String"));

            dgvProductosRecetario.DataSource = dtProducto;

            dgvProductosRecetario.Columns[0].DisplayIndex = 3;

            for (int i = 0; i < dgvProductosRecetario.Columns.Count; i++)
            {
                dgvProductosRecetario.Columns[i].Width = 250;
            }
        }

        private void Recetario_Load(object sender, EventArgs e)
        {
            GenerarDetalle();
        }

        private void dgvProductosRecetario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRow row = (DataRow)dtProducto.Rows[e.RowIndex];

                int piezas = Convert.ToInt32(row["Piezas"]);
                
                if(piezas > DetalleProducto.Stock)
                {
                    MessageBox.Show("La cantidad ingresada sobrepasa el stock","Sistema Mypo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    row["Piezas"] = 1;
                }

                if(piezas <= 0)
                {
                    MessageBox.Show("La cantidad ingresada es invalida", "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row["Piezas"] = 1;
                }

                DetalleProducto.Unidad = dgvProductosRecetario.CurrentRow.Cells[0].Value.ToString();
                row["Unidad"] = DetalleProducto.Unidad;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
