using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.Entidades
{
    public class HistorialUsuario
    {
        public int IdHistorialUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrase�a { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }

        public HistorialUsuario() { }

        public HistorialUsuario(string nombreUsuario, string contrase�a, string rol, DateTime fechaRegistro)
        {
            NombreUsuario = nombreUsuario;
            Contrase�a = contrase�a;
            Rol = rol;
            FechaRegistro = fechaRegistro;
        }
    }
}
