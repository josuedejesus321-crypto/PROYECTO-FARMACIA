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
using static Logica_Datos1.HistorialUsuarioBLL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblHistorial_Usuarios
{
    public partial class Historial_Usuarios : Form
    {
        private readonly HistorialUsuarioBLL _HistorialUsuarioBLL = new HistorialUsuarioBLL();
        public Historial_Usuarios()
        {
            InitializeComponent();
        }

        private void Historial_Usuarios_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscar.Text.Trim(); // Obtener el criterio de búsqueda y quitar espacios en blanco

            if (!string.IsNullOrEmpty(criterioBusqueda))
            {
                // Llamar a un método en tu capa de lógica para buscar usuarios por nombre de usuario
                List<Entidades.HistorialUsuario> resultados = _HistorialUsuarioBLL.BuscarUsuariosPorNombreUsuario(criterioBusqueda);

                // Actualizar el DataGridView con los resultados de la búsqueda
                dtgHistorial_Usuarios.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show($"No se encontraron usuarios con el nombre '{criterioBusqueda}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void refreshPantalla()
        {

            dtgHistorial_Usuarios.DataSource = _HistorialUsuarioBLL.ObtenerTodoElHistorialUsuarios();
        }
    }
}
