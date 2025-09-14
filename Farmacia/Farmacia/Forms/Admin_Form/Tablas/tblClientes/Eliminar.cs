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
using static Logica_Datos1.Consultas_ClientesDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblClientes
{
    public partial class Eliminar : Form
    {
        private readonly ClienteBLL _clienteBLL = new ClienteBLL();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID_Cliente.Text, out int idClienteAEliminar))
            {
                // Llamar al método de la capa de lógica para eliminar el cliente
                int filasAfectadas = _clienteBLL.EliminarCliente(idClienteAEliminar);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show($"Cliente con ID {idClienteAEliminar} eliminado correctamente.");
                    this.DialogResult = DialogResult.OK; 
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún cliente con el ID {idClienteAEliminar} o hubo un error al eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
