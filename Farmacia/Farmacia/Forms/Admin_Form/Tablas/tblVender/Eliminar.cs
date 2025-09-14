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
    public partial class Eliminar : Form
    {
        private readonly VentasBLL _VentasBLL = new VentasBLL();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID_Venta.Text, out int idDetalleAEliminar)) 
            {
                // Llamar al método de la capa de lógica para eliminar el detalle de venta
                int filasAfectadas = _VentasBLL.EliminarDetalleVenta(idDetalleAEliminar);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show($"Detalle de venta con ID {idDetalleAEliminar} eliminado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún detalle de venta con el ID {idDetalleAEliminar} o hubo un error al eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de detalle de venta válido.");
            }
        }
    }
}
