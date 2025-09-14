using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Datos1
{
    public class Login_verificacion
    {
        public string Verificar_usuario(string usuario, string contraseña)
        {
            if (usuario == "Admin" && contraseña == "Admin")
            {
                return "Admin";
            }
            else if (usuario == "Compra" && contraseña == "Compra")
            {
                return "Compra";
            }
            else if (usuario == "Venta" && contraseña == "Venta")
            {
                return "Venta";
            }
            else
            {
                return null;
            }
        }
    }
}
