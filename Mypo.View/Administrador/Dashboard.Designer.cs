namespace Mypo.View.Administrador
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSubMnuVentas = new System.Windows.Forms.Panel();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pnlSubMnuEmbarques = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnEmbarques = new System.Windows.Forms.Button();
            this.pnlSubMnuReportes = new System.Windows.Forms.Panel();
            this.btnReportesOrdenes = new System.Windows.Forms.Button();
            this.btnReportesVentas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pnlSubMnuAutenticacion = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnAutenticacion = new System.Windows.Forms.Button();
            this.pnlSubMnuInventario = new System.Windows.Forms.Panel();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlModulo = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.picbFoto = new System.Windows.Forms.PictureBox();
            this.TransicionMenu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlSubMnuVentas.SuspendLayout();
            this.pnlSubMnuEmbarques.SuspendLayout();
            this.pnlSubMnuReportes.SuspendLayout();
            this.pnlSubMnuAutenticacion.SuspendLayout();
            this.pnlSubMnuInventario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnNormal);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.TransicionMenu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMenu.Location = new System.Drawing.Point(12, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 35);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNormal.BackgroundImage")));
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnNormal, BunifuAnimatorNS.DecorationType.None);
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnNormal.Location = new System.Drawing.Point(1142, 12);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(20, 20);
            this.btnNormal.TabIndex = 8;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMaximizar.Location = new System.Drawing.Point(1142, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMinimizar.Location = new System.Drawing.Point(1116, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrar.Location = new System.Drawing.Point(1168, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.TransicionMenu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MYPO CRM";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlSubMnuVentas);
            this.pnlMenu.Controls.Add(this.btnVentas);
            this.pnlMenu.Controls.Add(this.pnlSubMnuEmbarques);
            this.pnlMenu.Controls.Add(this.btnEmbarques);
            this.pnlMenu.Controls.Add(this.pnlSubMnuReportes);
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.pnlSubMnuAutenticacion);
            this.pnlMenu.Controls.Add(this.btnAutenticacion);
            this.pnlMenu.Controls.Add(this.pnlSubMnuInventario);
            this.pnlMenu.Controls.Add(this.btnInventario);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.btnSignOut);
            this.TransicionMenu.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 738);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlSubMnuVentas
            // 
            this.pnlSubMnuVentas.Controls.Add(this.btnRegistros);
            this.pnlSubMnuVentas.Controls.Add(this.btnClientes);
            this.TransicionMenu.SetDecoration(this.pnlSubMnuVentas, BunifuAnimatorNS.DecorationType.None);
            this.pnlSubMnuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMnuVentas.Location = new System.Drawing.Point(0, 550);
            this.pnlSubMnuVentas.Name = "pnlSubMnuVentas";
            this.pnlSubMnuVentas.Size = new System.Drawing.Size(230, 77);
            this.pnlSubMnuVentas.TabIndex = 18;
            this.pnlSubMnuVentas.Visible = false;
            // 
            // btnRegistros
            // 
            this.btnRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnRegistros, BunifuAnimatorNS.DecorationType.None);
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.ForeColor = System.Drawing.Color.White;
            this.btnRegistros.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistros.Image")));
            this.btnRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistros.Location = new System.Drawing.Point(3, 44);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegistros.Size = new System.Drawing.Size(227, 32);
            this.btnRegistros.TabIndex = 1;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(3, 6);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(227, 32);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 518);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnVentas.Size = new System.Drawing.Size(230, 32);
            this.btnVentas.TabIndex = 17;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pnlSubMnuEmbarques
            // 
            this.pnlSubMnuEmbarques.Controls.Add(this.btnProveedores);
            this.pnlSubMnuEmbarques.Controls.Add(this.btnOrdenes);
            this.TransicionMenu.SetDecoration(this.pnlSubMnuEmbarques, BunifuAnimatorNS.DecorationType.None);
            this.pnlSubMnuEmbarques.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMnuEmbarques.Location = new System.Drawing.Point(0, 441);
            this.pnlSubMnuEmbarques.Name = "pnlSubMnuEmbarques";
            this.pnlSubMnuEmbarques.Size = new System.Drawing.Size(230, 77);
            this.pnlSubMnuEmbarques.TabIndex = 16;
            this.pnlSubMnuEmbarques.Visible = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnProveedores, BunifuAnimatorNS.DecorationType.None);
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(3, 44);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(227, 32);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnOrdenes, BunifuAnimatorNS.DecorationType.None);
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenes.Image")));
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.Location = new System.Drawing.Point(3, 6);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrdenes.Size = new System.Drawing.Size(227, 32);
            this.btnOrdenes.TabIndex = 1;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnEmbarques
            // 
            this.btnEmbarques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnEmbarques, BunifuAnimatorNS.DecorationType.None);
            this.btnEmbarques.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmbarques.FlatAppearance.BorderSize = 0;
            this.btnEmbarques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmbarques.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmbarques.ForeColor = System.Drawing.Color.White;
            this.btnEmbarques.Image = ((System.Drawing.Image)(resources.GetObject("btnEmbarques.Image")));
            this.btnEmbarques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmbarques.Location = new System.Drawing.Point(0, 409);
            this.btnEmbarques.Name = "btnEmbarques";
            this.btnEmbarques.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnEmbarques.Size = new System.Drawing.Size(230, 32);
            this.btnEmbarques.TabIndex = 15;
            this.btnEmbarques.Text = "Embarques";
            this.btnEmbarques.UseVisualStyleBackColor = true;
            this.btnEmbarques.Click += new System.EventHandler(this.btnEmbarques_Click);
            // 
            // pnlSubMnuReportes
            // 
            this.pnlSubMnuReportes.Controls.Add(this.btnReportesOrdenes);
            this.pnlSubMnuReportes.Controls.Add(this.btnReportesVentas);
            this.TransicionMenu.SetDecoration(this.pnlSubMnuReportes, BunifuAnimatorNS.DecorationType.None);
            this.pnlSubMnuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMnuReportes.Location = new System.Drawing.Point(0, 332);
            this.pnlSubMnuReportes.Name = "pnlSubMnuReportes";
            this.pnlSubMnuReportes.Size = new System.Drawing.Size(230, 77);
            this.pnlSubMnuReportes.TabIndex = 14;
            this.pnlSubMnuReportes.Visible = false;
            // 
            // btnReportesOrdenes
            // 
            this.btnReportesOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnReportesOrdenes, BunifuAnimatorNS.DecorationType.None);
            this.btnReportesOrdenes.FlatAppearance.BorderSize = 0;
            this.btnReportesOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesOrdenes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnReportesOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportesOrdenes.Image")));
            this.btnReportesOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesOrdenes.Location = new System.Drawing.Point(3, 44);
            this.btnReportesOrdenes.Name = "btnReportesOrdenes";
            this.btnReportesOrdenes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportesOrdenes.Size = new System.Drawing.Size(227, 32);
            this.btnReportesOrdenes.TabIndex = 1;
            this.btnReportesOrdenes.Text = "Ordenes";
            this.btnReportesOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnReportesVentas
            // 
            this.btnReportesVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnReportesVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnReportesVentas.FlatAppearance.BorderSize = 0;
            this.btnReportesVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesVentas.ForeColor = System.Drawing.Color.White;
            this.btnReportesVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnReportesVentas.Image")));
            this.btnReportesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesVentas.Location = new System.Drawing.Point(3, 6);
            this.btnReportesVentas.Name = "btnReportesVentas";
            this.btnReportesVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportesVentas.Size = new System.Drawing.Size(227, 32);
            this.btnReportesVentas.TabIndex = 1;
            this.btnReportesVentas.Text = "Ventas";
            this.btnReportesVentas.UseVisualStyleBackColor = true;
            this.btnReportesVentas.Click += new System.EventHandler(this.btnReportesVentas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnReportes, BunifuAnimatorNS.DecorationType.None);
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 300);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnReportes.Size = new System.Drawing.Size(230, 32);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pnlSubMnuAutenticacion
            // 
            this.pnlSubMnuAutenticacion.Controls.Add(this.btnUsuarios);
            this.pnlSubMnuAutenticacion.Controls.Add(this.btnRoles);
            this.TransicionMenu.SetDecoration(this.pnlSubMnuAutenticacion, BunifuAnimatorNS.DecorationType.None);
            this.pnlSubMnuAutenticacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMnuAutenticacion.Location = new System.Drawing.Point(0, 223);
            this.pnlSubMnuAutenticacion.Name = "pnlSubMnuAutenticacion";
            this.pnlSubMnuAutenticacion.Size = new System.Drawing.Size(230, 77);
            this.pnlSubMnuAutenticacion.TabIndex = 12;
            this.pnlSubMnuAutenticacion.Visible = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 44);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(227, 32);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnRoles, BunifuAnimatorNS.DecorationType.None);
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(3, 6);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRoles.Size = new System.Drawing.Size(227, 32);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnAutenticacion
            // 
            this.btnAutenticacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnAutenticacion, BunifuAnimatorNS.DecorationType.None);
            this.btnAutenticacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutenticacion.FlatAppearance.BorderSize = 0;
            this.btnAutenticacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutenticacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutenticacion.ForeColor = System.Drawing.Color.White;
            this.btnAutenticacion.Image = ((System.Drawing.Image)(resources.GetObject("btnAutenticacion.Image")));
            this.btnAutenticacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutenticacion.Location = new System.Drawing.Point(0, 191);
            this.btnAutenticacion.Name = "btnAutenticacion";
            this.btnAutenticacion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAutenticacion.Size = new System.Drawing.Size(230, 32);
            this.btnAutenticacion.TabIndex = 11;
            this.btnAutenticacion.Text = "Autenticación";
            this.btnAutenticacion.UseVisualStyleBackColor = true;
            this.btnAutenticacion.Click += new System.EventHandler(this.btnAutenticacion_Click);
            // 
            // pnlSubMnuInventario
            // 
            this.pnlSubMnuInventario.Controls.Add(this.btnEntradas);
            this.pnlSubMnuInventario.Controls.Add(this.btnProductos);
            this.pnlSubMnuInventario.Controls.Add(this.btnCategoria);
            this.TransicionMenu.SetDecoration(this.pnlSubMnuInventario, BunifuAnimatorNS.DecorationType.None);
            this.pnlSubMnuInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMnuInventario.Location = new System.Drawing.Point(0, 85);
            this.pnlSubMnuInventario.Name = "pnlSubMnuInventario";
            this.pnlSubMnuInventario.Size = new System.Drawing.Size(230, 106);
            this.pnlSubMnuInventario.TabIndex = 9;
            this.pnlSubMnuInventario.Visible = false;
            // 
            // btnEntradas
            // 
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnEntradas, BunifuAnimatorNS.DecorationType.None);
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.ForeColor = System.Drawing.Color.White;
            this.btnEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradas.Image")));
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.Location = new System.Drawing.Point(0, 35);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEntradas.Size = new System.Drawing.Size(230, 32);
            this.btnEntradas.TabIndex = 1;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnProductos, BunifuAnimatorNS.DecorationType.None);
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 68);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(230, 32);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnCategoria, BunifuAnimatorNS.DecorationType.None);
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(0, 0);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategoria.Size = new System.Drawing.Size(230, 32);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnInventario, BunifuAnimatorNS.DecorationType.None);
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 53);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnInventario.Size = new System.Drawing.Size(230, 32);
            this.btnInventario.TabIndex = 8;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 21);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnInicio.Size = new System.Drawing.Size(230, 32);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel3
            // 
            this.TransicionMenu.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 21);
            this.panel3.TabIndex = 3;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.btnSignOut, BunifuAnimatorNS.DecorationType.None);
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(0, 677);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(230, 35);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Cerrar Sesion";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pnlModulo
            // 
            this.pnlModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TransicionMenu.SetDecoration(this.pnlModulo, BunifuAnimatorNS.DecorationType.None);
            this.pnlModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModulo.Location = new System.Drawing.Point(230, 50);
            this.pnlModulo.Name = "pnlModulo";
            this.pnlModulo.Size = new System.Drawing.Size(970, 647);
            this.pnlModulo.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.picbFoto);
            this.TransicionMenu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(230, 697);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 91);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransicionMenu.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(109, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 42);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.TransicionMenu.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(106, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "{Nombre del usuario}";
            // 
            // picbFoto
            // 
            this.TransicionMenu.SetDecoration(this.picbFoto, BunifuAnimatorNS.DecorationType.None);
            this.picbFoto.Image = ((System.Drawing.Image)(resources.GetObject("picbFoto.Image")));
            this.picbFoto.Location = new System.Drawing.Point(0, 2);
            this.picbFoto.Name = "picbFoto";
            this.picbFoto.Size = new System.Drawing.Size(103, 89);
            this.picbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbFoto.TabIndex = 0;
            this.picbFoto.TabStop = false;
            // 
            // TransicionMenu
            // 
            this.TransicionMenu.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.TransicionMenu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.TransicionMenu.DefaultAnimation = animation1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.pnlModulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.TransicionMenu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mypo CRM";
            this.Load += new System.EventHandler(this.DashboardAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubMnuVentas.ResumeLayout(false);
            this.pnlSubMnuEmbarques.ResumeLayout(false);
            this.pnlSubMnuReportes.ResumeLayout(false);
            this.pnlSubMnuAutenticacion.ResumeLayout(false);
            this.pnlSubMnuInventario.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlModulo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlSubMnuInventario;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnAutenticacion;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Panel pnlSubMnuAutenticacion;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel pnlSubMnuReportes;
        private System.Windows.Forms.Button btnReportesOrdenes;
        private System.Windows.Forms.Button btnReportesVentas;
        private System.Windows.Forms.Button btnEmbarques;
        private System.Windows.Forms.Panel pnlSubMnuEmbarques;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel pnlSubMnuVentas;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox picbFoto;
        private BunifuAnimatorNS.BunifuTransition TransicionMenu;
    }
}