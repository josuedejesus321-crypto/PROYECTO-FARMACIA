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
            components = new System.ComponentModel.Container();
            sidebar = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            menuButton = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            btnHome = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            btnMedicamentos = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnVender = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            btnComprar = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            btnProveedores = new System.Windows.Forms.Button();
            panel7 = new System.Windows.Forms.Panel();
            btnClientes = new System.Windows.Forms.Button();
            HistorialesContainer = new System.Windows.Forms.Panel();
            panel11 = new System.Windows.Forms.Panel();
            Historial_Usuarios = new System.Windows.Forms.Button();
            panel10 = new System.Windows.Forms.Panel();
            btnHistorial_compras = new System.Windows.Forms.Button();
            panel9 = new System.Windows.Forms.Panel();
            btnHistorial_venta = new System.Windows.Forms.Button();
            panel8 = new System.Windows.Forms.Panel();
            btnHistorial = new System.Windows.Forms.Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            HistorialesTimer = new System.Windows.Forms.Timer(components);
            panelChildForm = new System.Windows.Forms.Panel();
            btnCerrar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            HistorialesContainer.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(HistorialesContainer);
            sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            sidebar.Location = new System.Drawing.Point(0, 0);
            sidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sidebar.MaximumSize = new System.Drawing.Size(286, 734);
            sidebar.MinimumSize = new System.Drawing.Size(80, 734);
            sidebar.Name = "sidebar";
            sidebar.Size = new System.Drawing.Size(286, 734);
            sidebar.TabIndex = 0;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new System.Drawing.Point(4, 3);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(282, 123);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(83, 40);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            menuButton.Image = Properties.Resources.Menu;
            menuButton.Location = new System.Drawing.Point(16, 33);
            menuButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new System.Drawing.Size(37, 36);
            menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Location = new System.Drawing.Point(4, 132);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(245, 48);
            panel2.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnHome.ForeColor = System.Drawing.Color.White;
            btnHome.Image = Properties.Resources.casa;
            btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.Location = new System.Drawing.Point(-26, -10);
            btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnHome.Size = new System.Drawing.Size(308, 70);
            btnHome.TabIndex = 0;
            btnHome.Text = "            Home";
            btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnMedicamentos);
            panel3.Location = new System.Drawing.Point(4, 186);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(245, 48);
            panel3.TabIndex = 2;
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMedicamentos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnMedicamentos.ForeColor = System.Drawing.Color.White;
            btnMedicamentos.Image = Properties.Resources.Medicamentos;
            btnMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMedicamentos.Location = new System.Drawing.Point(-26, -10);
            btnMedicamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnMedicamentos.Size = new System.Drawing.Size(287, 70);
            btnMedicamentos.TabIndex = 0;
            btnMedicamentos.Text = "            Medicamentos";
            btnMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMedicamentos.UseVisualStyleBackColor = true;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnVender);
            panel4.Location = new System.Drawing.Point(4, 240);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(245, 48);
            panel4.TabIndex = 2;
            // 
            // btnVender
            // 
            btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnVender.ForeColor = System.Drawing.Color.White;
            btnVender.Image = Properties.Resources.vender;
            btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVender.Location = new System.Drawing.Point(-26, -10);
            btnVender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVender.Name = "btnVender";
            btnVender.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnVender.Size = new System.Drawing.Size(287, 70);
            btnVender.TabIndex = 0;
            btnVender.Text = "            Vender";
            btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnComprar);
            panel5.Location = new System.Drawing.Point(4, 294);
            panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(245, 48);
            panel5.TabIndex = 3;
            // 
            // btnComprar
            // 
            btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnComprar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnComprar.ForeColor = System.Drawing.Color.White;
            btnComprar.Image = Properties.Resources.Compras;
            btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnComprar.Location = new System.Drawing.Point(-26, -10);
            btnComprar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnComprar.Name = "btnComprar";
            btnComprar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnComprar.Size = new System.Drawing.Size(287, 70);
            btnComprar.TabIndex = 0;
            btnComprar.Text = "            Comprar";
            btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnProveedores);
            panel6.Location = new System.Drawing.Point(4, 348);
            panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(245, 48);
            panel6.TabIndex = 4;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProveedores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = System.Drawing.Color.White;
            btnProveedores.Image = Properties.Resources.Proveedores;
            btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProveedores.Location = new System.Drawing.Point(-26, -10);
            btnProveedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnProveedores.Size = new System.Drawing.Size(287, 70);
            btnProveedores.TabIndex = 0;
            btnProveedores.Text = "            Proveedores";
            btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnClientes);
            panel7.Location = new System.Drawing.Point(4, 402);
            panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(245, 48);
            panel7.TabIndex = 5;
            // 
            // btnClientes
            // 
            btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClientes.ForeColor = System.Drawing.Color.White;
            btnClientes.Image = Properties.Resources.Clientes1;
            btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClientes.Location = new System.Drawing.Point(-26, -10);
            btnClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnClientes.Size = new System.Drawing.Size(287, 70);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "            Clientes";
            btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // HistorialesContainer
            // 
            HistorialesContainer.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            HistorialesContainer.Controls.Add(panel11);
            HistorialesContainer.Controls.Add(panel10);
            HistorialesContainer.Controls.Add(panel9);
            HistorialesContainer.Controls.Add(panel8);
            HistorialesContainer.Location = new System.Drawing.Point(4, 456);
            HistorialesContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            HistorialesContainer.MaximumSize = new System.Drawing.Size(240, 227);
            HistorialesContainer.MinimumSize = new System.Drawing.Size(240, 53);
            HistorialesContainer.Name = "HistorialesContainer";
            HistorialesContainer.Size = new System.Drawing.Size(240, 53);
            HistorialesContainer.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.Controls.Add(Historial_Usuarios);
            panel11.Location = new System.Drawing.Point(4, 171);
            panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new System.Drawing.Size(258, 53);
            panel11.TabIndex = 7;
            // 
            // Historial_Usuarios
            // 
            Historial_Usuarios.BackColor = System.Drawing.Color.FromArgb(50, 55, 60);
            Historial_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Historial_Usuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Historial_Usuarios.ForeColor = System.Drawing.Color.White;
            Historial_Usuarios.Image = Properties.Resources.punto16;
            Historial_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Historial_Usuarios.Location = new System.Drawing.Point(-26, -9);
            Historial_Usuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Historial_Usuarios.Name = "Historial_Usuarios";
            Historial_Usuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            Historial_Usuarios.Size = new System.Drawing.Size(287, 70);
            Historial_Usuarios.TabIndex = 0;
            Historial_Usuarios.Text = "            Usuarios";
            Historial_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Historial_Usuarios.UseVisualStyleBackColor = false;
            Historial_Usuarios.Click += Historial_Usuarios_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnHistorial_compras);
            panel10.Location = new System.Drawing.Point(4, 114);
            panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(258, 53);
            panel10.TabIndex = 7;
            // 
            // btnHistorial_compras
            // 
            btnHistorial_compras.BackColor = System.Drawing.Color.FromArgb(50, 55, 60);
            btnHistorial_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHistorial_compras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnHistorial_compras.ForeColor = System.Drawing.Color.White;
            btnHistorial_compras.Image = Properties.Resources.punto16;
            btnHistorial_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHistorial_compras.Location = new System.Drawing.Point(-26, -10);
            btnHistorial_compras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHistorial_compras.Name = "btnHistorial_compras";
            btnHistorial_compras.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnHistorial_compras.Size = new System.Drawing.Size(287, 70);
            btnHistorial_compras.TabIndex = 0;
            btnHistorial_compras.Text = "            Compras";
            btnHistorial_compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHistorial_compras.UseVisualStyleBackColor = false;
            btnHistorial_compras.Click += btnHistorial_compras_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnHistorial_venta);
            panel9.Location = new System.Drawing.Point(5, 59);
            panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(258, 53);
            panel9.TabIndex = 6;
            // 
            // btnHistorial_venta
            // 
            btnHistorial_venta.BackColor = System.Drawing.Color.FromArgb(50, 55, 60);
            btnHistorial_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHistorial_venta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnHistorial_venta.ForeColor = System.Drawing.Color.White;
            btnHistorial_venta.Image = Properties.Resources.punto16;
            btnHistorial_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHistorial_venta.Location = new System.Drawing.Point(-26, -10);
            btnHistorial_venta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHistorial_venta.Name = "btnHistorial_venta";
            btnHistorial_venta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnHistorial_venta.Size = new System.Drawing.Size(287, 70);
            btnHistorial_venta.TabIndex = 0;
            btnHistorial_venta.Text = "            Ventas";
            btnHistorial_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHistorial_venta.UseVisualStyleBackColor = false;
            btnHistorial_venta.Click += btnHistorial_venta_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnHistorial);
            panel8.Location = new System.Drawing.Point(4, 3);
            panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(258, 53);
            panel8.TabIndex = 5;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = System.Drawing.Color.White;
            btnHistorial.Image = Properties.Resources.Historial;
            btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHistorial.Location = new System.Drawing.Point(-28, -12);
            btnHistorial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnHistorial.Size = new System.Drawing.Size(287, 70);
            btnHistorial.TabIndex = 0;
            btnHistorial.Text = "            Historiales";
            btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // HistorialesTimer
            // 
            HistorialesTimer.Interval = 10;
            HistorialesTimer.Tick += HistorialesTimer_Tick;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            panelChildForm.Controls.Add(btnCerrar);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelChildForm.Location = new System.Drawing.Point(286, 0);
            panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new System.Drawing.Size(1096, 733);
            panelChildForm.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = System.Drawing.Color.Black;
            btnCerrar.Location = new System.Drawing.Point(1007, 14);
            btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(76, 38);
            btnCerrar.TabIndex = 27;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new System.Drawing.Point(308, 288);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(400, 100);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Admin_Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            ClientSize = new System.Drawing.Size(1382, 733);
            Controls.Add(panelChildForm);
            Controls.Add(sidebar);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Admin_Menu";
            Text = "Admin_menu";
            Load += Admin_Menu_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            HistorialesContainer.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

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