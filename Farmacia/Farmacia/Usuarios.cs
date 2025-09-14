using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Forms.Purchase_Form;
using Farmacia.Forms.Seller_Form;
using Logica_Datos1;

namespace Farmacia
{
    internal class Usuarios
    {


        public void ingreso_usuarios(System.Windows.Forms.DataGridView dataGridViewUsuarios)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Nombre_Usuario", typeof(string)); 
            table.Columns.Add("Contraseña", typeof(string));
            table.Columns.Add("Rol", typeof(string));
            table.Rows.Add("Admin", "Admin", "Administrador");
            table.Rows.Add("Compra", "Compra", "Comprador");
            table.Rows.Add("Venta", "Venta", "Vendedor");

            dataGridViewUsuarios.DataSource = table;
        }

        public string IniciarSesion(string usuario, string contraseña, Form loginForm)
        {
            Login_verificacion login = new Login_verificacion();
            string rol = login.Verificar_usuario(usuario, contraseña);

            if (rol != null)
            {
                loginForm.Hide();

                if (rol == "Admin")
                {
                    Admin_Menu admin = new Admin_Menu();
                    admin.Show();
                    MessageBox.Show("Bienvenido Administrador");
                }
                else if (rol == "Compra")
                {
                    Purchase_Form compra = new Purchase_Form();
                    compra.Show();
                    MessageBox.Show("Bienvenido Comprador");
                }
                else if (rol == "Venta")
                {
                    Seller_Form venta = new Seller_Form();
                    venta.Show();
                    MessageBox.Show("Bienvenido Vendedor");
                }

                
                return rol;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

    }
}

