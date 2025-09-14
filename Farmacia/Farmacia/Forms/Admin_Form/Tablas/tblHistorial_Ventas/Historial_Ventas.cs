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
using static Logica_Datos1.Consultas_Historial_VentasDAL;
using Logica_Datos1;
using static Logica_Datos1.Consultas_VentasDAL;
using System.Drawing.Printing;


namespace Farmacia.Forms.Admin_Form.Tablas.tblHistorial_Ventas
{
    public partial class Historial_Ventas : Form
    {
        private readonly HistorialVentaBLL _Historial_VentasBLL = new HistorialVentaBLL();

        private Entidades.Definir_Historial_Ventas.Historial_Ventas _filaSeleccionadaParaFactura;
        public Historial_Ventas()
        {
            InitializeComponent();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void Historial_Ventas_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscar.Text.Trim(); // Obtener el criterio de búsqueda y quitar espacios en blanco

            if (!string.IsNullOrEmpty(criterioBusqueda))
            {
                // Llamar a un método en tu capa de lógica para buscar en el historial de ventas
                if (int.TryParse(criterioBusqueda, out int idVenta))
                {
                    List<Entidades.Definir_Historial_Ventas.Historial_Ventas> resultados = _Historial_VentasBLL.ObtenerHistorialVentasPorIdVenta(idVenta);

                    // Actualizar el DataGridView con los resultados de la búsqueda
                    dtgHistorial_Ventas.DataSource = resultados;

                    if (resultados.Count == 0)
                    {
                        MessageBox.Show($"No se encontraron registros en el historial con el ID de venta '{criterioBusqueda}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de venta válido para la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            else
            {
                // Si el TextBox de búsqueda está vacío, podrías recargar todo el historial de ventas
                refreshPantalla();
            }
        }
        
        public void refreshPantalla()
        {

            dtgHistorial_Ventas.DataSource = _Historial_VentasBLL.ObtenerTodoElHistorialVentas();
        }

        private void dtgHistorial_Ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerar_Factura_Click(object sender, EventArgs e)
        {
            if (dtgHistorial_Ventas.SelectedRows.Count > 0)
            {
                // Obtiene el objeto de datos enlazado a la primera fila seleccionada.
                // Esto es mucho más eficiente y menos propenso a errores que acceder celda por celda.
                Entidades.Definir_Historial_Ventas.Historial_Ventas historialSeleccionado =
                    dtgHistorial_Ventas.SelectedRows[0].DataBoundItem as Entidades.Definir_Historial_Ventas.Historial_Ventas; //

                // Verifica si el casteo fue exitoso y si el objeto no es nulo
                if (historialSeleccionado != null)
                {
                    _filaSeleccionadaParaFactura = historialSeleccionado; // Asigna el objeto completo a la variable de clase
                    printPreviewDialog1.ShowDialog(); // Muestra el diálogo de vista previa de impresión
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la información completa de la fila seleccionada. " +
                                    "Por favor, verifica que el DataGridView esté enlazado a objetos de tipo 'Entidades.Definir_Historial_Ventas.Historial_Ventas'.",
                                    "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila del historial de ventas para generar la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontSmall = new Font("Arial", 8);
            Font fontRegular = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontTitle = new Font("Arial", 18, FontStyle.Bold);

            // Márgenes y posiciones iniciales
            float x = 50;
            float y = 50;
            float lineHeight = fontRegular.GetHeight(graphics) + 5; // Espacio entre líneas

            // Asegurarse de que hay datos para imprimir
            if (_filaSeleccionadaParaFactura == null)
            {
                e.HasMorePages = false;
                return;
            }

            // --- ENCABEZADO DE LA FACTURA ---
            // FARMACIA [Nombre de tu Farmacia] - Centro
            graphics.DrawString("FARMACIA Pharmacare", fontTitle, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("FARMACIA [Nombre de tu Farmacia]", fontTitle).Width / 2, y);
            y += fontTitle.GetHeight(graphics) + 5;
            graphics.DrawString("DIRECCION: [Dirección de la Farmacia]", fontSmall, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("DIRECCION: [Dirección de la Farmacia]", fontSmall).Width / 2, y);
            y += fontSmall.GetHeight(graphics);
            graphics.DrawString("R.N.C: XXXXXXXXX", fontSmall, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("R.N.C: XXXXXXXXX", fontSmall).Width / 2, y);
            y += lineHeight * 1.5f; // Más espacio para la siguiente sección

            // Título de la factura
            graphics.DrawString("FACTURA ORIGINAL", fontHeader, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("FACTURA ORIGINAL", fontHeader).Width / 2, y);
            y += lineHeight;

            // Número de Factura (simulado, ya que tu entidad es por ítem)
            graphics.DrawString($"FACTURA NO: {_filaSeleccionadaParaFactura.IdVenta.ToString().PadLeft(8, '0')}", fontRegular, Brushes.Black, x, y);
            y += lineHeight;
            graphics.DrawString("N.I.T: XXXXXXX", fontRegular, Brushes.Black, x, y); // Ejemplo, si tienes un NIT
            y += lineHeight;

            // Fecha y Hora (alineadas a la derecha como en el ejemplo)
            float dateX = e.PageBounds.Width - x - graphics.MeasureString($"FECHA: {_filaSeleccionadaParaFactura.FechaVenta.ToShortDateString()}", fontRegular).Width;
            graphics.DrawString($"FECHA: {_filaSeleccionadaParaFactura.FechaVenta.ToShortDateString()}", fontRegular, Brushes.Black, dateX, y - lineHeight);
            float timeX = e.PageBounds.Width - x - graphics.MeasureString($"HORA: {_filaSeleccionadaParaFactura.FechaVenta.ToShortTimeString()}", fontRegular).Width;
            graphics.DrawString($"HORA: {_filaSeleccionadaParaFactura.FechaVenta.ToShortTimeString()}", fontRegular, Brushes.Black, timeX, y);
            y += lineHeight * 2; // Salto de línea después de la hora

            // Nombre (Cliente, si lo tuvieras)
            // Actualmente, _filaSeleccionadaParaFactura no tiene nombre de cliente.
            // Si tuvieras un campo de cliente en tu entidad o pudieras obtenerlo, iría aquí.
            graphics.DrawString("NOMBRE: [Nombre del Cliente, si disponible]", fontRegular, Brushes.Black, x, y);
            y += lineHeight * 2;


            // --- ENCABEZADO DE LA TABLA DE ÍTEMS ---
            float colCanX = x;
            float colDescX = x + 70; // Espacio para Cantidad
            float colImpX = e.PageBounds.Width - x - graphics.MeasureString("IMPORTE", fontBold).Width; // Alineado a la derecha

            graphics.DrawString("CAN", fontBold, Brushes.Black, colCanX, y);
            graphics.DrawString("DESCRIPCION", fontBold, Brushes.Black, colDescX, y);
            graphics.DrawString("IMPORTE", fontBold, Brushes.Black, colImpX, y);
            y += lineHeight;

            // Línea separadora
            graphics.DrawLine(Pens.Black, x, y, e.PageBounds.Width - x, y);
            y += 5; // Pequeño espacio después de la línea

            // --- DETALLE DEL ARTÍCULO (Fila de la tabla) ---
            // Cantidad
            graphics.DrawString(_filaSeleccionadaParaFactura.CantidadVendida.ToString(), fontRegular, Brushes.Black, colCanX, y);
            // Descripción
            graphics.DrawString(_filaSeleccionadaParaFactura.NombreMedicamento, fontRegular, Brushes.Black, colDescX, y);
            // Importe (Cantidad * Precio Unitario)
            string importeStr = (_filaSeleccionadaParaFactura.CantidadVendida * _filaSeleccionadaParaFactura.PrecioUnitario).ToString("C2");
            graphics.DrawString(importeStr, fontRegular, Brushes.Black, colImpX, y);
            y += lineHeight * 2;

            // --- TOTALES ---
            y += 10; // Espacio adicional antes de los totales

            // Total a Pagar
            string totalStr = _filaSeleccionadaParaFactura.Total.ToString("C2");
            float totalLabelX = e.PageBounds.Width - x - graphics.MeasureString("TOTAL:", fontBold).Width - graphics.MeasureString(totalStr, fontRegular).Width - 10;
            graphics.DrawString("TOTAL:", fontBold, Brushes.Black, totalLabelX, y);
            graphics.DrawString(totalStr, fontRegular, Brushes.Black, colImpX, y);
            y += lineHeight;

            // Cambio (simulado si no está en tu entidad, o puedes poner 0.00)
            string cambioStr = 0.00M.ToString("C2"); // Asumiendo 0 de cambio si no se calcula
            float cambioLabelX = e.PageBounds.Width - x - graphics.MeasureString("CAMBIO:", fontBold).Width - graphics.MeasureString(cambioStr, fontRegular).Width - 10;
            graphics.DrawString("CAMBIO:", fontBold, Brushes.Black, cambioLabelX, y);
            graphics.DrawString(cambioStr, fontRegular, Brushes.Black, colImpX, y);
            y += lineHeight;

            // Sección "SON: Ochocientos trece 00/100 Bs" (simulado, necesitaría una función para convertir número a texto)
            graphics.DrawString($"SON: [Monto en letras] {_filaSeleccionadaParaFactura.Total:C2}", fontRegular, Brushes.Black, x, y); // Placeholder
            y += lineHeight * 2;

            // Información del cajero (si la tienes)
            graphics.DrawString($"CAJERO: {_filaSeleccionadaParaFactura.IdEmpleado}", fontRegular, Brushes.Black, x, y); // Usando IdEmpleado como Cajero
            y += lineHeight;

            // Pie de página - Agradecimiento
            graphics.DrawString("¡Gracias por tu compra!", fontBold, Brushes.Black, e.PageBounds.Width / 2 - graphics.MeasureString("¡Gracias por tu compra!", fontBold).Width / 2, y + lineHeight);

            e.HasMorePages = false; // Indica que no hay más páginas para imprimir
        }
    }
}

