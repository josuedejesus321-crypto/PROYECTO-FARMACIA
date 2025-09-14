using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Forms.Admin_Form.Tablas.tblVender;
using Entidades;
using static Logica_Datos1.Consultas_VentasDAL;
using Logica_Datos1;




namespace Farmacia.Forms.Admin_Form.Tablas.tblVender
{
    
    public partial class Ventas : Form
    {
        private readonly VentasBLL _VentasBLL = new VentasBLL();
        public Ventas()
        {
            InitializeComponent();
        }
        public void refreshPantalla()
        {

            dtgVentas.DataSource = _VentasBLL.ObtenerTodosLosDetallesVenta();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Añadir nuevoFormulario = new Añadir();
            nuevoFormulario.ShowDialog(); // Mostrar como diálogo modal
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
            if (dtgVentas.SelectedRows.Count > 0) 
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgVentas.SelectedRows[0];

                // Crear una instancia del formulario de modificación de DetalleVenta
                Modificar modificarForm = new Modificar();

                // Pasar los datos del detalle de venta seleccionado al formulario de modificación
                
                if (filaSeleccionada.Cells["IdDetalle"].Value != null)
                {
                    modificarForm.txtID_Detalle.Text = filaSeleccionada.Cells["IdDetalle"].Value.ToString();
                    modificarForm.txtID_Detalle.ReadOnly = true;
                }
                if (filaSeleccionada.Cells["IdVenta"].Value != null)
                {
                    modificarForm.txtId_Venta.Text = filaSeleccionada.Cells["IdVenta"].Value.ToString();
                }
                if (filaSeleccionada.Cells["IdMedicamento"].Value != null)
                {
                    modificarForm.txtID_Medicamento.Text = filaSeleccionada.Cells["IdMedicamento"].Value.ToString();
                }
                if (filaSeleccionada.Cells["Cantidad"].Value != null)
                {
                    modificarForm.txtCantidad.Text = filaSeleccionada.Cells["Cantidad"].Value.ToString();
                }
                if (filaSeleccionada.Cells["PrecioUnitario"].Value != null)
                {
                    modificarForm.txtPrecio_Unitario.Text = filaSeleccionada.Cells["PrecioUnitario"].Value.ToString();
                }

                // Mostrar el formulario de modificación de manera modal
                modificarForm.ShowDialog();

                refreshPantalla(); // Actualizar la vista después de cerrar el formulario de modificación
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un detalle de venta de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreABuscar = txtBuscar.Text.Trim(); // Obtener el texto de búsqueda y quitar espacios en blanco al principio y al final

            if (!string.IsNullOrEmpty(nombreABuscar))
            {
                // Llamar a un método en tu capa de lógica para buscar medicamentos por nombre
                List<Entidades.Definir_Ventas.DetalleVenta> resultados = _VentasBLL.ObtenerDetallesVentaPorIdVenta(nombreABuscar);

                // Actualizar el DataGridView con los resultados de la búsqueda
                dtgVentas.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show($"No se encontraron medicamentos con el nombre '{nombreABuscar}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Si el TextBox de búsqueda está vacío, podrías recargar todos los medicamentos
                refreshPantalla();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
