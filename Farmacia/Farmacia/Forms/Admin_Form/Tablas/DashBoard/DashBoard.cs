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
using Entidades;
using System.Reflection.Emit;

namespace Farmacia.Forms.Admin_Form.Tablas.DashBoard
{
    public partial class DashBoard : Form
    {
        private readonly DashBoardBLL _dashBoardBLL = new DashBoardBLL();
        public DashBoard()
        {
            InitializeComponent();
            CargarDatosDashboard();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private async void CargarDatosDashboard()
        {
            DashBoardInfo info = await Task.Run(() => _dashBoardBLL.ObtenerInformacionDashBoard());

            // Asigna los valores a los labels correspondientes
            lblStock.Text = info.CantidadFueraDeStock.ToString();
            lblClientes.Text = info.CantidadClientes.ToString();
            lblProveedores.Text = info.CantidadProveedores.ToString();
            lblMedicina.Text = info.CantidadMedicamentos.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
