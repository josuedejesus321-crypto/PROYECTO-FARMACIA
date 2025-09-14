using Entidades;
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
    public partial class Compras : Form
    {
        private readonly ComprasBLL _ComprasBLL = new ComprasBLL();
        public Compras()
        {
            InitializeComponent();
        }
        public void refreshPantalla()
        {

            dtgCompras.DataSource = _ComprasBLL.ObtenerTodosLasCompras();
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Añadir nuevoFormulario = new Añadir();
            nuevoFormulario.ShowDialog(); // Mostrar como diálogo modal
            refreshPantalla();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar nuevoFormulario = new Eliminar();
            nuevoFormulario.ShowDialog(); // Mostrar como diálogo modal
            refreshPantalla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgCompras.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgCompras.SelectedRows[0];

                // Crear una instancia del formulario de modificación de Compras
                Modificar modificarForm = new Modificar();

                // Pasar los datos de la compra seleccionada al formulario de modificación
                
                if (filaSeleccionada.Cells["IdCompra"].Value != null)
                {
                    modificarForm.txtID_Compra.Text = filaSeleccionada.Cells["IdCompra"].Value.ToString(); 
                    modificarForm.txtID_Compra.ReadOnly = true;
                }
                if (filaSeleccionada.Cells["IdProveedor"].Value != null)
                {
                    modificarForm.txtId_Proveedor.Text = filaSeleccionada.Cells["IdProveedor"].Value.ToString();
                }
                if (filaSeleccionada.Cells["FechaCompra"].Value != null)
                {
                    modificarForm.dtFecha_Compra.Value = Convert.ToDateTime(filaSeleccionada.Cells["FechaCompra"].Value);
                }
                if (filaSeleccionada.Cells["IdMedicamento"].Value != null)
                {
                    modificarForm.txtID_Medicamento.Text = filaSeleccionada.Cells["IdMedicamento"].Value.ToString();
                }
                if (filaSeleccionada.Cells["CantidadComprada"].Value != null)
                {
                    modificarForm.txtCantidad.Text = filaSeleccionada.Cells["CantidadComprada"].Value.ToString();
                }
                if (filaSeleccionada.Cells["PrecioUnidad"].Value != null)
                {
                    modificarForm.txtPrecio_Unidad.Text = filaSeleccionada.Cells["PrecioUnidad"].Value.ToString();
                }

                // Mostrar el formulario de modificación de manera modal
                modificarForm.ShowDialog();

                refreshPantalla(); // Actualizar la vista después de cerrar el formulario de modificación
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una compra de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ComprasBuscar = txtBuscar.Text.Trim(); // Obtener el texto de búsqueda y quitar espacios en blanco

            if (!string.IsNullOrEmpty(ComprasBuscar))
            {
                // Llamar al método en tu capa de lógica para buscar compras por IdProveedor
                List<Definir_Compras.Compras> resultados = _ComprasBLL.ObtenerCompraPorIdCompra(ComprasBuscar);

                // Actualizar el DataGridView con los resultados de la búsqueda
                dtgCompras.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show($"No se encontraron compras para el proveedor con ID '{ComprasBuscar}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                
                refreshPantalla(); 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
