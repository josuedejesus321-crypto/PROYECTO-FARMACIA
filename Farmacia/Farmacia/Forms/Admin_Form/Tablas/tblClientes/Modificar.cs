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
using Logica_Datos1;
using static Entidades.Definir_Clientes;
using static Logica_Datos1.Consultas_ClientesDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblClientes
{
    public partial class Modificar : Form
    {
        private readonly ClienteBLL _clienteBLL = new ClienteBLL();
        public Modificar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente clienteModificado = new Cliente 
            {
                IdCliente = int.Parse(txtID_Cliente.Text), 
                Nombre = txtNombre_Cliente.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Direccion = txtDireccion.Text
            };

            // Llamar al método de la capa de lógica para actualizar el cliente
            int filasAfectadas = _clienteBLL.ActualizarCliente(clienteModificado);

            if (filasAfectadas > 0)
            {
                MessageBox.Show($"Cliente con ID {clienteModificado.IdCliente} modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo para indicar éxito
                this.Close(); 
            }
            else
            {
                MessageBox.Show($"No se pudo modificar el cliente con ID {clienteModificado.IdCliente} o no se encontraron cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
