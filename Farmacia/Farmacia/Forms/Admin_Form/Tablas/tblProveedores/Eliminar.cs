using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_Datos1;
using static Logica_Datos1.Consultas_ProveedoresDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblProveedores
{
    public partial class Eliminar : Form
    {
        private readonly ProveedorBLL _proveedorBLL = new ProveedorBLL();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID_Proveedor.Text, out int idProveedorAEliminar)) // Usa txtID_Proveedor
            {
                // Llamar al método de la capa de lógica para eliminar el proveedor
                int filasAfectadas = _proveedorBLL.EliminarProveedor(idProveedorAEliminar);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show($"Proveedor con ID {idProveedorAEliminar} eliminado correctamente.");
                    this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo para indicar éxito
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún proveedor con el ID {idProveedorAEliminar} o hubo un error al eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de proveedor válido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
