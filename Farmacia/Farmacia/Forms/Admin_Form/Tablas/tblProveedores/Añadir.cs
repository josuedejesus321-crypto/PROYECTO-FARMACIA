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
    public partial class Añadir : Form
    {
        private readonly ProveedorBLL _proveedorBLL = new ProveedorBLL();
        public Añadir()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Entidades.Definir_Proveedores.Proveedores nuevoProveedor = new Entidades.Definir_Proveedores.Proveedores
            {
                // IdProveedor se generará automáticamente en la base de datos
                Nombre = txtNombre_Proveedor.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Email = txtEmail.Text
            };

            // Llamar al método de la capa de lógica para agregar el proveedor
            int filasAfectadas = _proveedorBLL.AgregarNuevoProveedor(nuevoProveedor);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Proveedor agregado correctamente.");
                this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo para indicar éxito
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el proveedor.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
