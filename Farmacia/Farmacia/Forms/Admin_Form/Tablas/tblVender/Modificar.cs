using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica_Datos1.Consultas_VentasDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblVender
{
    public partial class Modificar : Form
    {
        private readonly VentasBLL _VentasBLL = new VentasBLL();
        public Modificar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Definir_Ventas.DetalleVenta detalleVentaModificado = new Entidades.Definir_Ventas.DetalleVenta
            {
                IdDetalle = int.Parse(txtID_Detalle.Text), 
                IdVenta = int.Parse(txtId_Venta.Text),     
                IdMedicamento = int.Parse(txtID_Medicamento.Text),
                Cantidad = int.Parse(txtCantidad.Text),   
                PrecioUnitario = decimal.Parse(txtPrecio_Unitario.Text)
            };

            // Llamar al método de la capa de lógica para actualizar el detalle de venta
            int filasAfectadas = _VentasBLL.ActualizarDetalleVenta(detalleVentaModificado); // Asumo que tienes este método en VentasBLL

            if (filasAfectadas > 0)
            {
                MessageBox.Show($"Detalle de venta con ID {detalleVentaModificado.IdDetalle} modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo para indicar éxito
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show($"No se pudo modificar el detalle de venta con ID {detalleVentaModificado.IdDetalle} o no se encontraron cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
