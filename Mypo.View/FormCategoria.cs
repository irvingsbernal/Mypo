using Mypo.Controller;
using System;
using System.Windows.Forms;

namespace Mypo.View
{
    public partial class FormCategoria : Form
    {
        private string nombreCategoriaAnterior;
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = ControllerCategoria.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Registros totales: " + Convert.ToString(DgvListado.Rows.Count);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = ControllerCategoria.Buscar(TxtBuscar.Text);
                this.Formato();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[4].Width = 100;
        }

        private void Limpiar()
        {
            TxtId.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtBuscar.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            Erroricono.Clear();

            DgvListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            ChbSeleccionar.Checked = false;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mypo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = ""; 
                if(TxtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta completar algunos datos.");
                    Erroricono.SetError(TxtNombre, "Ingresa un nombre para la categoría.");
                }
                else
                {
                    Respuesta = ControllerCategoria.Insertar(TxtNombre.Text.Trim(), TxtDescripcion.Text.Trim());
                    if (Respuesta.Equals("Ok"))
                    {
                        this.MensajeOk("¡Se ha registrado con éxito una nueva categoría!");
                        this.Listar();
                        this.Limpiar();
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (TxtNombre.Text == string.Empty || TxtId.Text == string.Empty)
                {
                    this.MensajeError("Falta completar algunos datos.");
                    Erroricono.SetError(TxtNombre, "Ingresa un nombre para la categoría.");
                }
                else
                {
                    Respuesta = ControllerCategoria.Actualizar(Convert.ToInt32(TxtId.Text),this.nombreCategoriaAnterior,TxtNombre.Text.Trim(), TxtDescripcion.Text.Trim());
                    if (Respuesta.Equals("Ok"))
                    {
                        this.MensajeOk("¡Se ha actualizado con éxito una categoría!");
                        this.Listar();
                        this.Limpiar();
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                this.nombreCategoriaAnterior = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripción"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch(Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
            }
            
        }

        private void ChbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chbEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chbEliminar.Value = !Convert.ToBoolean(chbEliminar.Value);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente deseas eliminar este(os) ítem(s)?", "Sistema Mypo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(opcion == DialogResult.OK)
                {
                    int idEliminado;
                    string Respuesta = "";

                    foreach(DataGridViewRow fila in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            idEliminado = Convert.ToInt32(fila.Cells[1].Value);
                            Respuesta = ControllerCategoria.Eliminar(idEliminado);

                            if (Respuesta.Equals("Ok"))
                            {
                                MensajeOk("Se ha eliminado el registro: " + Convert.ToString(fila.Cells[2].Value));
                            }
                            else
                            {
                                MensajeError(Respuesta);
                            }
                        }
                    }

                    this.Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente deseas activar este(os) ítem(s)?", "Sistema Mypo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (opcion == DialogResult.OK)
                {
                    int idEliminado;
                    string Respuesta = "";

                    foreach (DataGridViewRow fila in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            idEliminado = Convert.ToInt32(fila.Cells[1].Value);
                            Respuesta = ControllerCategoria.Activar(idEliminado);

                            if (Respuesta.Equals("Ok"))
                            {
                                MensajeOk("Se ha activado el registro: " + Convert.ToString(fila.Cells[2].Value));
                            }
                            else
                            {
                                MensajeError(Respuesta);
                            }
                        }
                    }

                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente deseas desactivar este(os) ítem(s)?", "Sistema Mypo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (opcion == DialogResult.OK)
                {
                    int idEliminado;
                    string Respuesta = "";

                    foreach (DataGridViewRow fila in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            idEliminado = Convert.ToInt32(fila.Cells[1].Value);
                            Respuesta = ControllerCategoria.Desactivar(idEliminado);

                            if (Respuesta.Equals("Ok"))
                            {
                                MensajeOk("Se ha desactivado el registro: " + Convert.ToString(fila.Cells[2].Value));
                            }
                            else
                            {
                                MensajeError(Respuesta);
                            }
                        }
                    }

                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
