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
    public partial class Clientes : Form
    {
        private readonly ClienteBLL _clienteBLL = new ClienteBLL();
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreABuscar = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(nombreABuscar))
            {
                List<Cliente> resultados = _clienteBLL.ObtenerClientesPorNombre(nombreABuscar); 

                dtgCliente.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show($"No se encontraron clientes con el nombre '{nombreABuscar}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                refreshPantalla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar nuevoFormulario = new Eliminar(); 
            nuevoFormulario.ShowDialog();
            refreshPantalla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgCliente.SelectedRows[0];

                Modificar modificarForm = new Modificar();

                if (filaSeleccionada.Cells["IdCliente"].Value != null)
                {
                    modificarForm.txtID_Cliente.Text = filaSeleccionada.Cells["IdCliente"].Value.ToString();
                    modificarForm.txtID_Cliente.ReadOnly = true;
                }
                if (filaSeleccionada.Cells["Nombre"].Value != null)
                {
                    modificarForm.txtNombre_Cliente.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                }
                if (filaSeleccionada.Cells["Telefono"].Value != null)
                {
                    modificarForm.txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                }
                if (filaSeleccionada.Cells["Email"].Value != null)
                {
                    modificarForm.txtEmail.Text = filaSeleccionada.Cells["Email"].Value.ToString();
                }
                if (filaSeleccionada.Cells["Direccion"].Value != null)
                {
                    modificarForm.txtDireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                }

                modificarForm.ShowDialog();
                refreshPantalla();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Añadir nuevoFormulario = new Añadir();
            nuevoFormulario.ShowDialog();
            refreshPantalla();
        }

        public void refreshPantalla()
        {
            dtgCliente.DataSource = _clienteBLL.ObtenerTodosLosClientes(); 
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }
    }
}
