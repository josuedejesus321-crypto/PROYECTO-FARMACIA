using Logica_Datos1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica_Datos1.HistorialCompraBLL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblHistorial_Compras
{
    public partial class Historial_Compras : Form
    {
        private readonly HistorialCompraBLL _Historial_ComprasBLL = new HistorialCompraBLL();

        public Historial_Compras()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscar.Text.Trim(); // Obtener el criterio de búsqueda y quitar espacios en blanco

            if (!string.IsNullOrEmpty(criterioBusqueda))
            {
                // Llamar a un método en tu capa de lógica para buscar en el historial de compras
                if (int.TryParse(criterioBusqueda, out int idCompra))
                {
                    List<Entidades.HistorialCompra> resultados = _Historial_ComprasBLL.ObtenerHistorialComprasPorIdCompra(idCompra);

                    // Actualizar el DataGridView con los resultados de la búsqueda
                    dtgHistorial_Compras.DataSource = resultados;

                    if (resultados.Count == 0)
                    {
                        MessageBox.Show($"No se encontraron registros en el historial de compras con el ID de compra '{criterioBusqueda}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de compra válido para la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
               
                refreshPantalla();
            }
        }

        private void Historial_Compras_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        public void refreshPantalla()
        {

            dtgHistorial_Compras.DataSource = _Historial_ComprasBLL.ObtenerTodoElHistorialCompras();
        }
    }
}
