using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.Services
{
    public class Login_verificacion
    {
        public string Verificar_usuario(string usuario, string contrase�a)
        {
            if (usuario == "Admin" && contrase�a == "Admin")
            {
                return "Admin";
            }
            else if (usuario == "Compra" && contrase�a == "Compra")
            {
                return "Compra";
            }
            else if (usuario == "Venta" && contrase�a == "Venta")
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
