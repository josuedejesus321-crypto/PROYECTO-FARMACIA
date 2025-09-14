using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica_Datos1.Consultas_ProveedoresDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblProveedores
{
    public partial class Modificar : Form
    {
        private readonly ProveedorBLL _proveedorBLL = new ProveedorBLL();
        public Modificar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Definir_Proveedores.Proveedores proveedorModificado = new Entidades.Definir_Proveedores.Proveedores
            {
                IdProveedor = int.Parse(txtID_Proveedor.Text),
                Nombre = txtNombre_Proveedor.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Email = txtEmail.Text
            };

            // Llamar al método de la capa de lógica para actualizar el proveedor
            int filasAfectadas = _proveedorBLL.ActualizarProveedor(proveedorModificado);

            if (filasAfectadas > 0)
            {
                MessageBox.Show($"Proveedor con ID {proveedorModificado.IdProveedor} modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo para indicar éxito
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show($"No se pudo modificar el proveedor con ID {proveedorModificado.IdProveedor} o no se encontraron cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
