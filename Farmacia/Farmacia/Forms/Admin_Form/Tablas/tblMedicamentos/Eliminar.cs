using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica_Datos1.Consultas_MedicamentosDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblMedicamentos
{
    public partial class Eliminar : Form
    {
        private readonly MedicamentosBLL _medicamentosBLL = new MedicamentosBLL();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID_Medicamento.Text, out int idMedicamentoAEliminar))
            {
                // Llamar al método de la capa de lógica para eliminar el medicamento
                int filasAfectadas = _medicamentosBLL.EliminarNuevoMedicamento(idMedicamentoAEliminar);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show($"Medicamento con ID {idMedicamentoAEliminar} eliminado correctamente.");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún medicamento con el ID {idMedicamentoAEliminar} o hubo un error al eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de medicamento válido.");
            }

        }
    }
}
