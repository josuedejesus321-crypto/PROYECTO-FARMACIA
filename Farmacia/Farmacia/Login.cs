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

namespace Farmacia
{


    public partial class Login : Form
    {
        Usuarios u = new Usuarios();
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Login_KeyDown;
             u.ingreso_usuarios(dtgUsuarios);
            dtgUsuarios.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            u.ingreso_usuarios(dtgUsuarios);

        }

        private void btnIniciar_sesion_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text;
            u.IniciarSesion(usuario, contraseña, this);

        }

        private void Usuarios_SelectionChanged(object sender, EventArgs e)
        {
                

            if (dtgUsuarios.CurrentRow != null) 
            {
                txtusuario.Text = Convert.ToString(dtgUsuarios.CurrentRow.Cells["Nombre_Usuario"].Value);
                txtcontraseña.Text = Convert.ToString(dtgUsuarios.CurrentRow.Cells["Contraseña"].Value);
            }
            
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            //aqui le digo cual es la tecla para ocultar
            if (e.KeyCode == Keys.OemPipe)
            {
                // Hacer visible el DataGridView
                dtgUsuarios.Visible = true;
            }
        }

    }
}

