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
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }

        public HistorialUsuario() { }

        public HistorialUsuario(string nombreUsuario, string contraseña, string rol, DateTime fechaRegistro)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
            FechaRegistro = fechaRegistro;
        }
    }
}
