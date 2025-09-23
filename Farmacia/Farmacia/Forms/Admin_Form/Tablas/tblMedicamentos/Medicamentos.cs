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
using LogicaCompartida.Entidades;
using Farmacia.Forms.Admin_Form.Tablas.tblMedicamentos;
using IronBarCode;
using System.IO;
using System.Security.Cryptography;
using Farmacia.Config;




namespace Farmacia.Forms.Admin_Form.Tablas
{
    public partial class Medicamentos : Form
    {
        private readonly MedicamentosBLL _medicamentosBLL = new MedicamentosBLL();
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantalla()
        {
            
            dtgMedicamentos.DataSource = _medicamentosBLL.ObtenerTodosLosMedicamentos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Medicamentos_Load_1(object sender, EventArgs e)
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
            if (dtgMedicamentos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgMedicamentos.SelectedRows[0];

                // Crear una instancia del formulario de modificación
                Modificar modificarForm = new Modificar();

                // Pasar los datos del medicamento seleccionado al formulario de modificación
                modificarForm.txtID_Medicamento.Text = filaSeleccionada.Cells["IdMedicamento"].Value.ToString();
                modificarForm.txtNombre_Medicamento.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                modificarForm.txtNombre_Generico_Medicamento.Text = filaSeleccionada.Cells["NombreGenerico"].Value.ToString();
                modificarForm.txtCategoria_Medicamento.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
                modificarForm.txtEstante_Medicamento.Text = filaSeleccionada.Cells["Estante"].Value.ToString();
                modificarForm.txtPrecioVenta_Medicamento.Text = filaSeleccionada.Cells["PrecioVenta"].Value.ToString();
                modificarForm.txtPrecioproveedor_Medicamento.Text = filaSeleccionada.Cells["PrecioProveedor"].Value.ToString();
                modificarForm.txtStock_Medicamento.Text = filaSeleccionada.Cells["Stock"].Value.ToString();
                modificarForm.txtIdProveedor.Text = filaSeleccionada.Cells["IdProveedor"].Value.ToString();

                // Deshabilitar el TextBox del ID para que no se pueda modificar (opcional)
                modificarForm.txtID_Medicamento.ReadOnly = true;

                // Mostrar el formulario de modificación de manera modal (hasta que se cierre)
                modificarForm.ShowDialog();

                refreshPantalla();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un medicamento de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreABuscar = txtBuscar.Text.Trim(); // Obtener el texto de búsqueda y quitar espacios en blanco al principio y al final

            if (!string.IsNullOrEmpty(nombreABuscar))
            {
                // Llamar a un método en tu capa de lógica para buscar medicamentos por nombre
                List<LogicaCompartida.Entidades.Definir_Medicamentos.Medicamentos> resultados = _medicamentosBLL.ObtenerMedicamentosPorNombre(nombreABuscar);

                // Actualizar el DataGridView con los resultados de la búsqueda
                dtgMedicamentos.DataSource = resultados;

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

        private void btnCodigo_Barras_Click(object sender, EventArgs e)
        {
            if (dtgMedicamentos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgMedicamentos.SelectedRows[0];
                string idMedicamento = filaSeleccionada.Cells["IdMedicamento"].Value.ToString();

                // Obtener la ruta de destino según el dispositivo actual
                string carpetaDestino = ConfiguracionDispositivo.ObtenerRutaCodigoBarras();

                // Verificar que la ruta sea accesible
                if (!ConfiguracionDispositivo.VerificarAccesoRuta())
                {
                    MessageBox.Show($"No se puede acceder a la carpeta de recursos.\nDispositivo: {ConfiguracionDispositivo.ObtenerInfoDispositivo()}", 
                        "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Genera un nombre de archivo único para cada código
                string nombreArchivo = $"codigo_barras_{DateTime.Now.Ticks}.png";

                //Combina la ruta de destino y el nombre del archivo
                string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

                //Crea una instancia del formulario
                Codigo_Barras Codigo_BarrasForm = new Codigo_Barras();

                
      

                // Llama al método para crear y guardar el código en la nueva ruta
                crearCodigoBarras(idMedicamento, BarcodeWriterEncoding.Code128, Codigo_BarrasForm.Codigo, rutaCompleta);
                               

                Codigo_BarrasForm.ShowDialog();
                refreshPantalla();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un medicamento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void crearCodigoBarras(string codigo, BarcodeWriterEncoding tipo, PictureBox picture, string imagen)
        {
            // Creamos una instancia de GeneratedBarcode
            GeneratedBarcode MiCodigo = BarcodeWriter.CreateBarcode(codigo, tipo);

            // Agregamos el codigo despues la imagen del codigo de barras
            MiCodigo.AddAnnotationTextBelowBarcode(codigo);

            // Margen
            MiCodigo.SetMargins(30);

            // Color
            MiCodigo.ChangeBarCodeColor(Color.Black);

            // Guardamos la imagen
            MiCodigo.SaveAsPng(imagen);

            // La seteamos al picture box
            picture.Image = Image.FromFile(imagen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Escaner EscanerForm = new Escaner();
            EscanerForm.ShowDialog();
            refreshPantalla();
        }
    }
}
    
