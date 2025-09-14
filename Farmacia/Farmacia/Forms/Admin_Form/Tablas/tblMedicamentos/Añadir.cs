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
using Entidades;


namespace Farmacia.Forms.Admin_Form.Tablas.tblMedicamentos
{
    public partial class Añadir : Form
    {
        private readonly MedicamentosBLL _medicamentosBLL = new MedicamentosBLL();
        public Añadir()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Entidades.Definir_Medicamentos.Medicamentos nuevoMedicamento = new Entidades.Definir_Medicamentos.Medicamentos
            {
                Nombre = txtNombre_Medicamento.Text,
                NombreGenerico = txtNombre_Generico_Medicamento.Text,
                Categoria = txtCategoria_Medicamento.Text, 
                Estante = txtEstante_Medicamento.Text,
                PrecioVenta = decimal.Parse(txtPrecioVenta_Medicamento.Text), 
                PrecioProveedor = decimal.Parse(txtPrecioproveedor_Medicamento.Text),
                Stock = int.Parse(txtStock_Medicamento.Text), 
                IdProveedor = int.Parse(txtIdProveedor.Text) 
                
            };

            // Llamar al método de la capa de lógica para agregar el medicamento
            int filasAfectadas = _medicamentosBLL.AgregarNuevoMedicamento(nuevoMedicamento);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Medicamento agregado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el medicamento.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Añadir_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Generico_Medicamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
