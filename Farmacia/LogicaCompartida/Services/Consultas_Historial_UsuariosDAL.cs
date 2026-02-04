using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;

namespace LogicaCompartida.Services
{
    public class HistorialUsuarioBLL 
    {
        public List<Definir_Historial_Usuario> ObtenerTodoElHistorialUsuarios()
        {
            return Consultas_Historial_Usuarios.ObtenerTodoElHistorialUsuarios();
        }

        public List<Definir_Historial_Usuario> BuscarUsuariosPorNombreUsuario(string nombreUsuario)
        {
            return Consultas_Historial_Usuarios.BuscarUsuariosPorNombreUsuario(nombreUsuario);        }

        
    }
}
