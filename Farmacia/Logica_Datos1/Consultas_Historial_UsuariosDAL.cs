using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataBase;

namespace Logica_Datos1
{
    public class HistorialUsuarioBLL 
    {
        public List<HistorialUsuario> ObtenerTodoElHistorialUsuarios()
        {
            return Consultas_Historial_Usuarios.ObtenerTodoElHistorialUsuarios();
        }

        public List<HistorialUsuario> BuscarUsuariosPorNombreUsuario(string nombreUsuario)
        {
            return Consultas_Historial_Usuarios.BuscarUsuariosPorNombreUsuario(nombreUsuario);        }

        
    }
}