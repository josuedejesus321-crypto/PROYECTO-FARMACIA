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
    public partial class Eliminar : Form
    {
        private readonly ComprasBLL _ComprasBLL = new ComprasBLL();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID_Compras.Text, out int idCompra))
            {
                // Llamar al método de la capa de lógica para eliminar la compra
                int filasAfectadas = _ComprasBLL.EliminarCompra(idCompra);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show($"Compra con ID {idCompra} eliminada correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"No se encontró ninguna compra con el ID {idCompra} o hubo un error al eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de compra válido.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
