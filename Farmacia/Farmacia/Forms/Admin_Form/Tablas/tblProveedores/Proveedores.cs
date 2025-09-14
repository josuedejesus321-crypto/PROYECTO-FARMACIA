using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Forms.Admin_Form.Tablas.tblProveedores; 
using Entidades;
using Logica_Datos1;
using static Logica_Datos1.Consultas_ProveedoresDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblProveedores
{
    public partial class Proveedores : Form
    {
        private readonly ProveedorBLL _proveedorBLL = new ProveedorBLL();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        public void refreshPantalla()
        {
            dtgProveedor.DataSource = _proveedorBLL.ObtenerTodosLosProveedores(); 
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Añadir nuevoFormulario = new Añadir(); // Crea un formulario para añadir proveedores
            nuevoFormulario.ShowDialog(); // Mostrar como diálogo modal
            refreshPantalla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgProveedor.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgProveedor.SelectedRows[0];

                // Crear una instancia del formulario de modificación de Proveedor
                Modificar modificarForm = new Modificar(); // Crea un formulario para modificar proveedores

                // Pasar los datos del proveedor seleccionado al formulario de modificación

                if (filaSeleccionada.Cells["IdProveedor"].Value != null)
                {
                    modificarForm.txtID_Proveedor.Text = filaSeleccionada.Cells["IdProveedor"].Value.ToString();
                    modificarForm.txtID_Proveedor.ReadOnly = true;
                }
                if (filaSeleccionada.Cells["Nombre"].Value != null)
                {
                    modificarForm.txtNombre_Proveedor.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                }
                if (filaSeleccionada.Cells["Telefono"].Value != null)
                {
                    modificarForm.txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                }
                if (filaSeleccionada.Cells["Direccion"].Value != null)
                {
                    modificarForm.txtDireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                }
                if (filaSeleccionada.Cells["Email"].Value != null)
                {
                    modificarForm.txtEmail.Text = filaSeleccionada.Cells["Email"].Value.ToString();
                }

                // Mostrar el formulario de modificación de manera modal
                modificarForm.ShowDialog();

                refreshPantalla(); // Actualizar la vista después de cerrar el formulario de modificación
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar nuevoFormulario = new Eliminar(); // Crea un formulario para eliminar proveedores
            nuevoFormulario.ShowDialog(); // Mostrar como diálogo modal
            refreshPantalla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreABuscar = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(nombreABuscar))
            {
                // Llamar al método en tu capa de lógica para buscar proveedores por nombre
                List<Definir_Proveedores.Proveedores> resultados = _proveedorBLL.ObtenerProveedoresPorNombre(nombreABuscar);

                // Actualizar el DataGridView con los resultados de la búsqueda
                dtgProveedor.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show($"No se encontraron proveedores con el nombre '{nombreABuscar}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Si el TextBox de búsqueda está vacío, podrías recargar todos los proveedores
                refreshPantalla();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
