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
using static Entidades.Definir_Medicamentos;
using static Logica_Datos1.Consultas_MedicamentosDAL;

namespace Farmacia.Forms.Admin_Form.Tablas.tblMedicamentos
{
    public partial class Modificar : Form
    {
        private readonly MedicamentosBLL _medicamentosBLL = new MedicamentosBLL();

        public Modificar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Definir_Medicamentos.Medicamentos medicamentoModificado = new Entidades.Definir_Medicamentos.Medicamentos
            {
                IdMedicamento = int.Parse(txtID_Medicamento.Text), 
                Nombre = txtNombre_Medicamento.Text,
                NombreGenerico = txtNombre_Generico_Medicamento.Text,
                Categoria = txtCategoria_Medicamento.Text,
                Estante = txtEstante_Medicamento.Text,
                PrecioVenta = decimal.Parse(txtPrecioVenta_Medicamento.Text),
                PrecioProveedor = decimal.Parse(txtPrecioproveedor_Medicamento.Text),
                Stock = int.Parse(txtStock_Medicamento.Text),
                IdProveedor = int.Parse(txtIdProveedor.Text)
                
            };

            // Llamar al método de la capa de lógica para actualizar el medicamento
            int filasAfectadas = _medicamentosBLL.ActualizarMedicamento(medicamentoModificado);

            if (filasAfectadas > 0)
            {
                MessageBox.Show($"Medicamento con ID {medicamentoModificado.IdMedicamento} modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo para indicar éxito
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show($"No se pudo modificar el medicamento con ID {medicamentoModificado.IdMedicamento} o no se encontraron cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNombre_Medicamento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
