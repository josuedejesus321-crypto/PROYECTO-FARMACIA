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

    public partial class Añadir : Form
    {
        private readonly ClienteBLL _clienteBLL = new ClienteBLL();
        public Añadir()
        {
            InitializeComponent();
        }

        private void Añadir_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente 
            {
                
                Nombre = txtNombre_Proveedor.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Direccion = txtDireccion.Text
            };

            // Llamar al método de la capa de lógica para agregar el cliente
            int filasAfectadas = _clienteBLL.AgregarNuevoCliente(nuevoCliente);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Cliente agregado correctamente.");
                this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo para indicar éxito
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el cliente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
