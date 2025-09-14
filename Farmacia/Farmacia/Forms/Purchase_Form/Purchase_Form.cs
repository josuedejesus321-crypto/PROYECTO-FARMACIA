using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Forms.Admin_Form.Tablas.DashBoard;
using Farmacia.Forms.Admin_Form.Tablas.tblCompras;
using Farmacia.Forms.Admin_Form.Tablas.tblProveedores;
using Farmacia.Forms.Admin_Form.Tablas.tblMedicamentos;
using Farmacia.Forms.Admin_Form.Tablas;

namespace Farmacia.Forms.Purchase_Form
{
    public partial class Purchase_Form : Form
    {
        Admin_Design AD = new Admin_Design();
        bool sidebarExpand;
        bool HistorialesCollapsed;
        public Purchase_Form()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            AD.sidebar_Animacion(sidebar, sidebarTimer, ref sidebarExpand);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new DashBoard());
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            openChildForm(new Medicamentos());
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            openChildForm(new Compras());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new Proveedores());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();


            loginForm.Show();


            this.Close();
        }

        private void Purchase_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
