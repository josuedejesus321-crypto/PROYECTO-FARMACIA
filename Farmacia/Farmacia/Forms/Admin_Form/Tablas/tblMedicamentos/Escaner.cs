using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static Entidades.Definir_Medicamentos;
using static Logica_Datos1.Consultas_MedicamentosDAL;
using System.Drawing.Printing;


namespace Farmacia.Forms.Admin_Form.Tablas.tblMedicamentos
{
    
    public partial class Escaner : Form
    {
        private readonly MedicamentosBLL _medicamentosBLL = new MedicamentosBLL();
        // Declara una lista para almacenar los medicamentos escaneados
        private List<Entidades.Definir_Medicamentos.Medicamentos> productosEscaneados = new List<Entidades.Definir_Medicamentos.Medicamentos>();
        // Declara un contador para la posición de los nuevos labels
        private int yPosition = 10;
        private List<Label> etiquetasDinamicas = new List<Label>();
        //Declaraciones de variables
        private decimal totalVenta = 0;
        private decimal totalITBS = 0;
        private const decimal tasaITBS = 0.18m;

        public Escaner()
        {
            InitializeComponent();
            this.ActiveControl = txtCodigo_barras;
            this.printDocument1 = new PrintDocument();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void Codigo_barras_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_Medicamento_Click(object sender, EventArgs e)
        {

        }

        private void Precio_Medicamento_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_barras_KeyDown(object sender, KeyEventArgs e)
        {
            // El escáner de código de barras emite la tecla Enter al final
            if (e.KeyCode == Keys.Enter)
            {
                // Obtiene el ID del medicamento del TextBox
                string idMedicamento = txtCodigo_barras.Text.Trim();

                if (!string.IsNullOrEmpty(idMedicamento))
                {
                    // Llama al método de tu capa de lógica para buscar el medicamento
                    Entidades.Definir_Medicamentos.Medicamentos medicamentoEncontrado = MedicamentosBLL.ObtenerMedicamentosPorCodigo(idMedicamento);

                    // Verifica si se encontró el medicamento
                    if (medicamentoEncontrado != null)
                    {
                        // Añade el medicamento a la lista
                        productosEscaneados.Add(medicamentoEncontrado);

                        // Calcula el ITBS del producto actual
                        decimal itbsProducto = medicamentoEncontrado.PrecioVenta * tasaITBS;

                        //Suma el precio del producto y su ITBS al total
                        totalVenta += medicamentoEncontrado.PrecioVenta + itbsProducto;

                        //Suma el ITBS del producto al total de ITBS
                        totalITBS += itbsProducto;

                        //Actualiza el Label del total.
                        lblTotal.Text = $" {totalVenta:C}";

                        //Actualiza el Label del ITBS
                        lblITBS.Text = $" {totalITBS:C}";

                        // Llama al método para crear y mostrar los labels dinámicamente
                        MostrarNuevoProducto(medicamentoEncontrado);

                        // Muestra el nombre y precio del último escaneo en los labels originales, si quieres mantener la funcionalidad
                        // Si no, puedes eliminar estas dos líneas para que los labels originales queden en N/A
                        lblNombre_Medicamento.Text = $"Nombre: {medicamentoEncontrado.Nombre}";
                        lblPrecio_Medicamento.Text = $"Precio: {medicamentoEncontrado.PrecioVenta:C}";
                    }
                    else
                    {
                        // Si no se encuentra, muestra un mensaje de error en los labels originales
                        lblNombre_Medicamento.Text = "Producto no encontrado.";
                        lblPrecio_Medicamento.Text = "Precio: N/A";
                        MessageBox.Show("No se encontró ningún medicamento con ese código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Limpia el TextBox para el siguiente escaneo, sin importar si hubo un resultado
                txtCodigo_barras.Clear();
                // Opcional: evita el sonido de "ding" al presionar Enter
                e.SuppressKeyPress = true;
            }
        }
        private void MostrarNuevoProducto(Entidades.Definir_Medicamentos.Medicamentos medicamento)
        {
            // Crea un nuevo Label para el nombre del producto
            Label nuevoNombreLabel = new Label();
            nuevoNombreLabel.Text = $"Nombre: {medicamento.Nombre}";
            nuevoNombreLabel.AutoSize = true;
            nuevoNombreLabel.Location = new System.Drawing.Point(20, yPosition);
            pnlScroll.Controls.Add(nuevoNombreLabel);
            etiquetasDinamicas.Add(nuevoNombreLabel);

            // Crea un nuevo Label para el precio del producto
            Label nuevoPrecioLabel = new Label();
            nuevoPrecioLabel.Text = $"Precio: {medicamento.PrecioVenta:C}";
            nuevoPrecioLabel.AutoSize = true;
            nuevoPrecioLabel.Location = new System.Drawing.Point(20, yPosition + 20);
            pnlScroll.Controls.Add(nuevoPrecioLabel);
            etiquetasDinamicas.Add(nuevoPrecioLabel);

            // Incrementa la posición Y para el siguiente par de labels
            yPosition += 40;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Elimina todas las etiquetas dinámicas del formulario
            foreach (var label in etiquetasDinamicas)
            {
                pnlScroll.Controls.Remove(label);
                label.Dispose(); // Libera los recursos de la etiqueta
            }

            // Limpia la lista de etiquetas
            etiquetasDinamicas.Clear();

            // Restablece la posición Y
            yPosition = 10;

            //Restablece la variable del total y el ITBS a cero
            totalVenta = 0;
            lblTotal.Text = "0";
            lblITBS.Text = "0";

            productosEscaneados.Clear();

            // restablecer los labels iniciales
            lblNombre_Medicamento.Text = "N/A";
            lblPrecio_Medicamento.Text = "N/A";
        
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Factura_Click(object sender, EventArgs e)
        {
            // Asegúrate de que haya productos en la lista antes de intentar imprimir
            if (productosEscaneados.Count > 0)
            {
                printPreviewDialog1.ShowDialog(); // Muestra el diálogo de vista previa de impresión
            }
            else
            {
                MessageBox.Show("No hay productos escaneados para generar una factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // [NUEVO] - Lógica para el diseño de la factura
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontSmall = new Font("Arial", 8);
            Font fontRegular = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontTitle = new Font("Arial", 18, FontStyle.Bold);

            float x = 50;
            float y = 50;
            float lineHeight = fontRegular.GetHeight(graphics) + 5;

            // Variables para los totales en la factura
            decimal subtotal = 0;
            decimal itbsTotal = 0;

            // --- ENCABEZADO DE LA FACTURA ---
            graphics.DrawString("FARMACIA Pharmacare", fontTitle, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("FARMACIA Pharmacare", fontTitle).Width / 2, y);
            y += fontTitle.GetHeight(graphics) + 5;
            graphics.DrawString("DIRECCION: [Dirección de la Farmacia]", fontSmall, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("DIRECCION: [Dirección de la Farmacia]", fontSmall).Width / 2, y);
            y += fontSmall.GetHeight(graphics);
            graphics.DrawString("R.N.C: XXXXXXXXX", fontSmall, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("R.N.C: XXXXXXXXX", fontSmall).Width / 2, y);
            y += lineHeight * 1.5f;

            graphics.DrawString("FACTURA ORIGINAL", fontHeader, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("FACTURA ORIGINAL", fontHeader).Width / 2, y);
            y += lineHeight;

            graphics.DrawString($"FECHA: {DateTime.Now.ToShortDateString()}", fontRegular, Brushes.Black, x, y);
            y += lineHeight;
            graphics.DrawString($"HORA: {DateTime.Now.ToShortTimeString()}", fontRegular, Brushes.Black, x, y);
            y += lineHeight * 2;

            // --- ENCABEZADO DE LA TABLA DE ÍTEMS ---
            float colCanX = x;
            float colDescX = x + 70;
            float colPrecioUnitX = colDescX + 250;
            float colImpX = e.PageBounds.Width - x - graphics.MeasureString("IMPORTE", fontBold).Width;

            graphics.DrawString("CAN", fontBold, Brushes.Black, colCanX, y);
            graphics.DrawString("DESCRIPCION", fontBold, Brushes.Black, colDescX, y);
            graphics.DrawString("PRECIO", fontBold, Brushes.Black, colPrecioUnitX, y);
            graphics.DrawString("IMPORTE", fontBold, Brushes.Black, colImpX, y);
            y += lineHeight;

            graphics.DrawLine(Pens.Black, x, y, e.PageBounds.Width - x, y);
            y += 5;

            // --- DETALLE DEL ARTÍCULO (Loop through all products) ---
            foreach (var producto in productosEscaneados)
            {
                // Cantidad
                graphics.DrawString("1", fontRegular, Brushes.Black, colCanX, y); // Asumiendo que escaneas un producto a la vez
                // Descripción
                graphics.DrawString(producto.Nombre, fontRegular, Brushes.Black, colDescX, y);
                // Precio Unitario
                graphics.DrawString(producto.PrecioVenta.ToString("C2"), fontRegular, Brushes.Black, colPrecioUnitX, y);
                // Importe del producto
                decimal importeProducto = producto.PrecioVenta;
                graphics.DrawString(importeProducto.ToString("C2"), fontRegular, Brushes.Black, colImpX, y);
                y += lineHeight;

                subtotal += importeProducto;
            }

            // Calcula el ITBS y el total final basado en el subtotal
            itbsTotal = subtotal * tasaITBS;
            decimal totalFinal = subtotal + itbsTotal;

            y += 10; // Espacio adicional antes de los totales

            // --- TOTALES ---
            graphics.DrawLine(Pens.Black, x, y, e.PageBounds.Width - x, y);
            y += 5;

            string subtotalStr = subtotal.ToString("C2");
            float subtotalLabelX = e.PageBounds.Width - x - graphics.MeasureString("SUBTOTAL:", fontBold).Width - graphics.MeasureString(subtotalStr, fontRegular).Width - 10;
            graphics.DrawString("SUBTOTAL:", fontBold, Brushes.Black, subtotalLabelX, y);
            graphics.DrawString(subtotalStr, fontRegular, Brushes.Black, colImpX, y);
            y += lineHeight;

            string itbsStr = itbsTotal.ToString("C2");
            float itbsLabelX = e.PageBounds.Width - x - graphics.MeasureString("ITBS (18%):", fontBold).Width - graphics.MeasureString(itbsStr, fontRegular).Width - 10;
            graphics.DrawString("ITBS (18%):", fontBold, Brushes.Black, itbsLabelX, y);
            graphics.DrawString(itbsStr, fontRegular, Brushes.Black, colImpX, y);
            y += lineHeight;

            string totalFinalStr = totalFinal.ToString("C2");
            float totalFinalLabelX = e.PageBounds.Width - x - graphics.MeasureString("TOTAL:", fontBold).Width - graphics.MeasureString(totalFinalStr, fontRegular).Width - 10;
            graphics.DrawString("TOTAL:", fontBold, Brushes.Black, totalFinalLabelX, y);
            graphics.DrawString(totalFinalStr, fontRegular, Brushes.Black, colImpX, y);
            y += lineHeight * 2;

            graphics.DrawString("¡Gracias por su compra!", fontBold, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("¡Gracias por su compra!", fontBold).Width / 2, y + lineHeight);

            e.HasMorePages = false;
        }
        
            private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
