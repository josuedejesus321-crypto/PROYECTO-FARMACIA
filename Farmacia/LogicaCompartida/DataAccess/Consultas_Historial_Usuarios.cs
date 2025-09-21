using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCompartida.Entidades;

namespace LogicaCompartida.DataAccess
{
    public class Consultas_Historial_Usuarios
    {
        //-------------------------------------------------------------Presentar registros del historial de usuarios
        public static List<HistorialUsuario> ObtenerTodoElHistorialUsuarios()
        {
            List<HistorialUsuario> lista = new List<HistorialUsuario>();

            using (SqlConnection conexion = LogicaCompartida.DataAccess.Conexion.ObtenerConexion())
            {
                
                string query = "SELECT IdHistorialUsuario, Nombre_Usuario, Contraseña, Rol, FechaRegistro FROM HistorialUsuarios"; // Ajusta la tabla y columnas
                SqlCommand comando = new SqlCommand(query, conexion);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistorialUsuario historial = new HistorialUsuario
                        {
                            IdHistorialUsuario = reader.GetInt32(0),
                            NombreUsuario = reader.GetString(1),
                            Contraseña = reader.GetString(2),
                            Rol = reader.GetString(3),
                            FechaRegistro = reader.GetDateTime(4)
                        };
                        lista.Add(historial);
                    }
                }
                conexion.Close();
                return lista;
            }
        }

        //-------------------------------------------------------------Buscar registros de usuarios por Nombre de Usuario
        public static List<HistorialUsuario> BuscarUsuariosPorNombreUsuario(string nombreUsuario)
        {
            List<HistorialUsuario> lista = new List<HistorialUsuario>();

            using (SqlConnection conexion = LogicaCompartida.DataAccess.Conexion.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT IdHistorialUsuario, Nombre_Usuario, Contraseña, Rol, FechaRegistro FROM HistorialUsuarios WHERE Nombre_Usuario LIKE @NombreUsuario";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NombreUsuario", "%" + nombreUsuario + "%"); // Usar LIKE para búsqueda parcial

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistorialUsuario historial = new HistorialUsuario
                        {
                            IdHistorialUsuario = reader.GetInt32(0),
                            NombreUsuario = reader.GetString(1),
                            Contraseña = reader.GetString(2),
                            Rol = reader.GetString(3),
                            FechaRegistro = reader.GetDateTime(4)
                        };
                        lista.Add(historial);
                    }
                }
                conexion.Close();
                return lista;
            }
        }

        
    }
}
