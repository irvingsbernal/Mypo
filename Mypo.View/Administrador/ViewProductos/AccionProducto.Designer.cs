namespace Mypo.View.Administrador.ViewProductos
{
    partial class AccionProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccionProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccion = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerarCodigoBarra = new System.Windows.Forms.Button();
            this.picbCodigo = new System.Windows.Forms.PictureBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioNeto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picbFoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSeleccionarImg = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.lblReceta = new System.Windows.Forms.Label();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.lblAccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAccion.Location = new System.Drawing.Point(389, 9);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(152, 25);
            this.lblAccion.TabIndex = 1;
            this.lblAccion.Text = "{Accion producto}";
            this.lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(117, 93);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(325, 21);
            this.cmbCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(117, 200);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(325, 20);
            this.txtUPC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "UPC:";
            // 
            // btnGenerarCodigoBarra
            // 
            this.btnGenerarCodigoBarra.FlatAppearance.BorderSize = 0;
            this.btnGenerarCodigoBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCodigoBarra.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarCodigoBarra.Image")));
            this.btnGenerarCodigoBarra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarCodigoBarra.Location = new System.Drawing.Point(117, 248);
            this.btnGenerarCodigoBarra.Name = "btnGenerarCodigoBarra";
            this.btnGenerarCodigoBarra.Size = new System.Drawing.Size(325, 23);
            this.btnGenerarCodigoBarra.TabIndex = 2;
            this.btnGenerarCodigoBarra.Text = "Generar código";
            this.btnGenerarCodigoBarra.UseVisualStyleBackColor = true;
            this.btnGenerarCodigoBarra.Click += new System.EventHandler(this.btnGenerarCodigoBarra_Click);
            // 
            // picbCodigo
            // 
            this.picbCodigo.Location = new System.Drawing.Point(117, 300);
            this.picbCodigo.Name = "picbCodigo";
            this.picbCodigo.Size = new System.Drawing.Size(325, 78);
            this.picbCodigo.TabIndex = 5;
            this.picbCodigo.TabStop = false;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(117, 418);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(325, 20);
            this.txtStock.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio de venta:";
            // 
            // txtPrecioNeto
            // 
            this.txtPrecioNeto.Location = new System.Drawing.Point(155, 461);
            this.txtPrecioNeto.Name = "txtPrecioNeto";
            this.txtPrecioNeto.Size = new System.Drawing.Size(287, 20);
            this.txtPrecioNeto.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(505, 300);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(349, 78);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descripcion:";
            // 
            // picbFoto
            // 
            this.picbFoto.Location = new System.Drawing.Point(505, 116);
            this.picbFoto.Name = "picbFoto";
            this.picbFoto.Size = new System.Drawing.Size(349, 155);
            this.picbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbFoto.TabIndex = 8;
            this.picbFoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Foto:";
            // 
            // btnSeleccionarImg
            // 
            this.btnSeleccionarImg.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarImg.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarImg.Image")));
            this.btnSeleccionarImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarImg.Location = new System.Drawing.Point(678, 79);
            this.btnSeleccionarImg.Name = "btnSeleccionarImg";
            this.btnSeleccionarImg.Size = new System.Drawing.Size(176, 34);
            this.btnSeleccionarImg.TabIndex = 5;
            this.btnSeleccionarImg.Text = "Seleccionar";
            this.btnSeleccionarImg.UseVisualStyleBackColor = true;
            this.btnSeleccionarImg.Click += new System.EventHandler(this.btnSeleccionarImg_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(41, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(117, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(325, 20);
            this.txtID.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(296, 497);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 41);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(505, 497);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 41);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(505, 58);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(127, 17);
            this.chbEstado.TabIndex = 12;
            this.chbEstado.Text = "{Estado de producto}";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceta.Location = new System.Drawing.Point(501, 392);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(55, 20);
            this.lblReceta.TabIndex = 13;
            this.lblReceta.Text = "Receta:";
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAgregarReceta.FlatAppearance.BorderSize = 0;
            this.btnAgregarReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReceta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReceta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarReceta.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarReceta.Image")));
            this.btnAgregarReceta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarReceta.Location = new System.Drawing.Point(505, 414);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(349, 45);
            this.btnAgregarReceta.TabIndex = 14;
            this.btnAgregarReceta.Text = "Agregar";
            this.btnAgregarReceta.UseVisualStyleBackColor = false;
            this.btnAgregarReceta.Click += new System.EventHandler(this.btnAgregarReceta_Click);
            // 
            // AccionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 550);
            this.Controls.Add(this.btnAgregarReceta);
            this.Controls.Add(this.lblReceta);
            this.Controls.Add(this.chbEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionarImg);
            this.Controls.Add(this.picbFoto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.picbCodigo);
            this.Controls.Add(this.btnGenerarCodigoBarra);
            this.Controls.Add(this.txtPrecioNeto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccionProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccionProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccion;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerarCodigoBarra;
        private System.Windows.Forms.PictureBox picbCodigo;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioNeto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picbFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSeleccionarImg;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.Button btnAgregarReceta;
    }
}