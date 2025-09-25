using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.Entidades
{
    public class Definir_Clientes
    {
        public class Cliente
        {
            public int IdCliente { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Direccion { get; set; }

            public Cliente() { }

            public Cliente(string nombre, string telefono, string email, string direccion)
            {
                this.Nombre = nombre;
                this.Telefono = telefono;
                this.Email = email;
                this.Direccion = direccion;
            }
        }


    }


        
    
}
