using Farmacia.Forms;
using Farmacia.Forms.Admin_Form.Tablas;
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
using Farmacia.Forms.Admin_Form.Tablas.tblCompras;
using Farmacia.Forms.Admin_Form.Tablas.tblProveedores;
using Farmacia.Forms.Admin_Form.Tablas.tblClientes;
using Farmacia.Forms.Admin_Form.Tablas.tblHistorial_Ventas;
using Entidades;
using Farmacia.Forms.Admin_Form.Tablas.tblHistorial_Compras;
using Farmacia.Forms.Admin_Form.Tablas.tblHistorial_Usuarios;
using Farmacia.Forms.Admin_Form.Tablas.DashBoard;

namespace Farmacia
{
    public partial class Admin_Menu : Form
    {
        Admin_Design AD = new Admin_Design();
        bool sidebarExpand;
        bool HistorialesCollapsed;
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new DashBoard());
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            
            AD.sidebar_Animacion(sidebar,sidebarTimer, ref sidebarExpand);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistorialesTimer_Tick(object sender, EventArgs e)
        {
            AD.Submenu_Animacion(HistorialesContainer, HistorialesTimer, ref HistorialesCollapsed);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            //bajar el intervalo para que la animacion sea suave
            HistorialesTimer.Start();
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

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            openChildForm(new Medicamentos());
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            openChildForm(new Ventas());
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            openChildForm(new Compras());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new Proveedores());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new Clientes());
        }

        private void btnHistorial_venta_Click(object sender, EventArgs e)
        {
            openChildForm(new Historial_Ventas());
        }

        private void btnHistorial_compras_Click(object sender, EventArgs e)
        {
            openChildForm(new Historial_Compras());
        }

        private void Historial_Usuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Historial_Usuarios());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); 

            
            loginForm.Show();

            
            this.Close();
        }
    }
}
