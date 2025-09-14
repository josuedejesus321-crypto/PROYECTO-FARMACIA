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
using Farmacia.Forms.Admin_Form.Tablas.tblClientes;
using Farmacia.Forms.Admin_Form.Tablas.DashBoard;
using Farmacia.Forms.Admin_Form.Tablas;

namespace Farmacia.Forms.Seller_Form
{
    public partial class Seller_Form : Form
    {
        Admin_Design AD = new Admin_Design();
        bool sidebarExpand;
        bool HistorialesCollapsed;
        public Seller_Form()
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

        private void btnVender_Click(object sender, EventArgs e)
        {
            openChildForm(new Ventas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new Clientes());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();


            loginForm.Show();


            this.Close();
        }
    }
}
