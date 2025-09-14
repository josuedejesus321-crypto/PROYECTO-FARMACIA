using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica_Datos1.Consultas_ComprasDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblCompras
{
    public partial class Añadir : Form
    {
        private readonly ComprasBLL _ComprasBLL = new ComprasBLL();
        public Añadir()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Entidades.Definir_Compras.Compras nuevaCompra = new Entidades.Definir_Compras.Compras
            {
                // IdCompra se generará automáticamente en la base de datos
                IdProveedor = int.Parse(txtId_Proveedor.Text), 
                FechaCompra = dtFecha_Compra.Value,        
                IdMedicamento = int.Parse(txtID_Medicamento.Text),
                CantidadComprada = int.Parse(txtCantidad.Text),
                PrecioUnidad = decimal.Parse(txtPrecio_Unidad.Text)    
            };

            // Llamar al método de la capa de lógica para agregar la compra
            int filasAfectadas = _ComprasBLL.AgregarNuevaCompra(nuevaCompra);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Compra agregada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar la compra.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
