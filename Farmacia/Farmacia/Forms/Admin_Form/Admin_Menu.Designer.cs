namespace Farmacia
{
    partial class Admin_Menu
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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnComprar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.HistorialesContainer = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.Historial_Usuarios = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnHistorial_compras = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnHistorial_venta = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.HistorialesTimer = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.HistorialesContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.HistorialesContainer);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(245, 636);
            this.sidebar.MinimumSize = new System.Drawing.Size(69, 636);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(245, 636);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 107);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Farmacia.Properties.Resources.Menu;
            this.menuButton.Location = new System.Drawing.Point(14, 29);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(32, 31);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(3, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Farmacia.Properties.Resources.casa;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-22, -9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(264, 61);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "            Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMedicamentos);
            this.panel3.Location = new System.Drawing.Point(3, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 42);
            this.panel3.TabIndex = 2;
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicamentos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamentos.ForeColor = System.Drawing.Color.White;
            this.btnMedicamentos.Image = global::Farmacia.Properties.Resources.Medicamentos;
            this.btnMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicamentos.Location = new System.Drawing.Point(-22, -9);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMedicamentos.Size = new System.Drawing.Size(246, 61);
            this.btnMedicamentos.TabIndex = 0;
            this.btnMedicamentos.Text = "            Medicamentos";
            this.btnMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicamentos.UseVisualStyleBackColor = true;
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnVender);
            this.panel4.Location = new System.Drawing.Point(3, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 42);
            this.panel4.TabIndex = 2;
            // 
            // btnVender
            // 
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Image = global::Farmacia.Properties.Resources.vender;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Location = new System.Drawing.Point(-22, -9);
            this.btnVender.Name = "btnVender";
            this.btnVender.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVender.Size = new System.Drawing.Size(246, 61);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "            Vender";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnComprar);
            this.panel5.Location = new System.Drawing.Point(3, 260);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 42);
            this.panel5.TabIndex = 3;
            // 
            // btnComprar
            // 
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Image = global::Farmacia.Properties.Resources.Compras;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(-22, -9);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnComprar.Size = new System.Drawing.Size(246, 61);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "            Comprar";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnProveedores);
            this.panel6.Location = new System.Drawing.Point(3, 308);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 42);
            this.panel6.TabIndex = 4;
            // 
            // btnProveedores
            // 
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = global::Farmacia.Properties.Resources.Proveedores;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(-22, -9);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(246, 61);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = "            Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnClientes);
            this.panel7.Location = new System.Drawing.Point(3, 356);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(210, 42);
            this.panel7.TabIndex = 5;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::Farmacia.Properties.Resources.Clientes1;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-22, -9);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(246, 61);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "            Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // HistorialesContainer
            // 
            this.HistorialesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.HistorialesContainer.Controls.Add(this.panel11);
            this.HistorialesContainer.Controls.Add(this.panel10);
            this.HistorialesContainer.Controls.Add(this.panel9);
            this.HistorialesContainer.Controls.Add(this.panel8);
            this.HistorialesContainer.Location = new System.Drawing.Point(3, 404);
            this.HistorialesContainer.MaximumSize = new System.Drawing.Size(206, 197);
            this.HistorialesContainer.MinimumSize = new System.Drawing.Size(206, 46);
            this.HistorialesContainer.Name = "HistorialesContainer";
            this.HistorialesContainer.Size = new System.Drawing.Size(206, 46);
            this.HistorialesContainer.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.Historial_Usuarios);
            this.panel11.Location = new System.Drawing.Point(3, 148);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(221, 46);
            this.panel11.TabIndex = 7;
            // 
            // Historial_Usuarios
            // 
            this.Historial_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.Historial_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Historial_Usuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historial_Usuarios.ForeColor = System.Drawing.Color.White;
            this.Historial_Usuarios.Image = global::Farmacia.Properties.Resources.punto16;
            this.Historial_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Historial_Usuarios.Location = new System.Drawing.Point(-22, -8);
            this.Historial_Usuarios.Name = "Historial_Usuarios";
            this.Historial_Usuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Historial_Usuarios.Size = new System.Drawing.Size(246, 61);
            this.Historial_Usuarios.TabIndex = 0;
            this.Historial_Usuarios.Text = "            Usuarios";
            this.Historial_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Historial_Usuarios.UseVisualStyleBackColor = false;
            this.Historial_Usuarios.Click += new System.EventHandler(this.Historial_Usuarios_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnHistorial_compras);
            this.panel10.Location = new System.Drawing.Point(3, 99);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(221, 46);
            this.panel10.TabIndex = 7;
            // 
            // btnHistorial_compras
            // 
            this.btnHistorial_compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnHistorial_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial_compras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial_compras.ForeColor = System.Drawing.Color.White;
            this.btnHistorial_compras.Image = global::Farmacia.Properties.Resources.punto16;
            this.btnHistorial_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial_compras.Location = new System.Drawing.Point(-22, -9);
            this.btnHistorial_compras.Name = "btnHistorial_compras";
            this.btnHistorial_compras.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHistorial_compras.Size = new System.Drawing.Size(246, 61);
            this.btnHistorial_compras.TabIndex = 0;
            this.btnHistorial_compras.Text = "            Compras";
            this.btnHistorial_compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial_compras.UseVisualStyleBackColor = false;
            this.btnHistorial_compras.Click += new System.EventHandler(this.btnHistorial_compras_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnHistorial_venta);
            this.panel9.Location = new System.Drawing.Point(4, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(221, 46);
            this.panel9.TabIndex = 6;
            // 
            // btnHistorial_venta
            // 
            this.btnHistorial_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnHistorial_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial_venta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial_venta.ForeColor = System.Drawing.Color.White;
            this.btnHistorial_venta.Image = global::Farmacia.Properties.Resources.punto16;
            this.btnHistorial_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial_venta.Location = new System.Drawing.Point(-22, -9);
            this.btnHistorial_venta.Name = "btnHistorial_venta";
            this.btnHistorial_venta.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHistorial_venta.Size = new System.Drawing.Size(246, 61);
            this.btnHistorial_venta.TabIndex = 0;
            this.btnHistorial_venta.Text = "            Ventas";
            this.btnHistorial_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial_venta.UseVisualStyleBackColor = false;
            this.btnHistorial_venta.Click += new System.EventHandler(this.btnHistorial_venta_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnHistorial);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(221, 46);
            this.panel8.TabIndex = 5;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Image = global::Farmacia.Properties.Resources.Historial;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(-24, -10);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(246, 61);
            this.btnHistorial.TabIndex = 0;
            this.btnHistorial.Text = "            Historiales";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // HistorialesTimer
            // 
            this.HistorialesTimer.Interval = 10;
            this.HistorialesTimer.Tick += new System.EventHandler(this.HistorialesTimer_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelChildForm.Controls.Add(this.btnCerrar);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(245, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(940, 635);
            this.panelChildForm.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(863, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(65, 33);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Farmacia.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(264, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1185, 635);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.sidebar);
            this.Name = "Admin_Menu";
            this.Text = "Admin_menu";
            this.Load += new System.EventHandler(this.Admin_Menu_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.HistorialesContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMedicamentos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer HistorialesTimer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel HistorialesContainer;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button Historial_Usuarios;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnHistorial_compras;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnHistorial_venta;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCerrar;
    }
}