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
    public partial class Añadir : Form
    {
        private readonly VentasBLL _VentasBLL = new VentasBLL();
        public Añadir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Definir_Ventas.DetalleVenta nuevoDetalleVenta = new Entidades.Definir_Ventas.DetalleVenta
            {
                // IdDetalle se generará automáticamente en la base de datos
                IdVenta = int.Parse(txtId_Venta.Text),     
                IdMedicamento = int.Parse(txtID_Medicamento.Text),
                Cantidad = int.Parse(txtCantidad.Text),   
                PrecioUnitario = decimal.Parse(txtPrecio_Unitario.Text)
            };

            // Llamar al método de la capa de lógica para agregar el detalle de venta
            int filasAfectadas = _VentasBLL.AgregarNuevoDetalleVenta(nuevoDetalleVenta);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Detalle de venta agregado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el detalle de venta.");
            }
        }
    }
}
