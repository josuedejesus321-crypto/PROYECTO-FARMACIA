using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.Entidades
{
    public class Definir_Proveedores
    {
        public class Proveedores
        {
            public int IdProveedor { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public string Email { get; set; }

            public Proveedores() { }

            public Proveedores(string nombre, string telefono, string direccion, string email)
            {
                this.Nombre = nombre;
                this.Telefono = telefono;
                this.Direccion = direccion;
                this.Email = email;
            }
        }


    }


        
    
}
