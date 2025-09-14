namespace Farmacia.Forms.Admin_Form.Tablas.tblMedicamentos
{
    partial class Escaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escaner));
            this.lblNombre_Medicamento = new System.Windows.Forms.Label();
            this.lblPrecio_Medicamento = new System.Windows.Forms.Label();
            this.txtCodigo_barras = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblITBS = new System.Windows.Forms.Label();
            this.btnGenerar_Factura = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblNombre_Medicamento
            // 
            this.lblNombre_Medicamento.AutoSize = true;
            this.lblNombre_Medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_Medicamento.Location = new System.Drawing.Point(333, 43);
            this.lblNombre_Medicamento.Name = "lblNombre_Medicamento";
            this.lblNombre_Medicamento.Size = new System.Drawing.Size(45, 24);
            this.lblNombre_Medicamento.TabIndex = 2;
            this.lblNombre_Medicamento.Text = "N/A";
            this.lblNombre_Medicamento.Click += new System.EventHandler(this.Nombre_Medicamento_Click);
            // 
            // lblPrecio_Medicamento
            // 
            this.lblPrecio_Medicamento.AutoSize = true;
            this.lblPrecio_Medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio_Medicamento.Location = new System.Drawing.Point(333, 67);
            this.lblPrecio_Medicamento.Name = "lblPrecio_Medicamento";
            this.lblPrecio_Medicamento.Size = new System.Drawing.Size(45, 24);
            this.lblPrecio_Medicamento.TabIndex = 3;
            this.lblPrecio_Medicamento.Text = "N/A";
            this.lblPrecio_Medicamento.Click += new System.EventHandler(this.Precio_Medicamento_Click);
            // 
            // txtCodigo_barras
            // 
            this.txtCodigo_barras.Location = new System.Drawing.Point(18, 19);
            this.txtCodigo_barras.Name = "txtCodigo_barras";
            this.txtCodigo_barras.Size = new System.Drawing.Size(217, 20);
            this.txtCodigo_barras.TabIndex = 4;
            this.txtCodigo_barras.TextChanged += new System.EventHandler(this.Codigo_barras_TextChanged);
            this.txtCodigo_barras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_barras_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(241, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 20);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Location = new System.Drawing.Point(18, 45);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(277, 248);
            this.pnlScroll.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "ITBS:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(390, 226);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 24);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "N/A";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblITBS
            // 
            this.lblITBS.AutoSize = true;
            this.lblITBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBS.Location = new System.Drawing.Point(390, 188);
            this.lblITBS.Name = "lblITBS";
            this.lblITBS.Size = new System.Drawing.Size(45, 24);
            this.lblITBS.TabIndex = 10;
            this.lblITBS.Text = "N/A";
            // 
            // btnGenerar_Factura
            // 
            this.btnGenerar_Factura.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerar_Factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGenerar_Factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar_Factura.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar_Factura.ForeColor = System.Drawing.Color.White;
            this.btnGenerar_Factura.Location = new System.Drawing.Point(219, 308);
            this.btnGenerar_Factura.Name = "btnGenerar_Factura";
            this.btnGenerar_Factura.Size = new System.Drawing.Size(159, 31);
            this.btnGenerar_Factura.TabIndex = 31;
            this.btnGenerar_Factura.Text = "Generar Factura";
            this.btnGenerar_Factura.UseVisualStyleBackColor = false;
            this.btnGenerar_Factura.Click += new System.EventHandler(this.btnGenerar_Factura_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Escaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 351);
            this.Controls.Add(this.btnGenerar_Factura);
            this.Controls.Add(this.lblITBS);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCodigo_barras);
            this.Controls.Add(this.lblPrecio_Medicamento);
            this.Controls.Add(this.lblNombre_Medicamento);
            this.Name = "Escaner";
            this.Text = "Escaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre_Medicamento;
        private System.Windows.Forms.Label lblPrecio_Medicamento;
        private System.Windows.Forms.TextBox txtCodigo_barras;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblITBS;
        private System.Windows.Forms.Button btnGenerar_Factura;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}