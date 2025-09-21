using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCompartida.Entidades;

namespace LogicaCompartida.DataAccess
{
    public class Consultas_Historial_Compras
    {
        //-------------------------------------------------------------Presentar registros del historial de compras
        public static List<HistorialCompra> ObtenerTodoElHistorialCompras() 
        {
            List<HistorialCompra> lista = new List<HistorialCompra>();

            using (SqlConnection conexion = LogicaCompartida.DataAccess.Conexion.ObtenerConexion())
            {
                
                string query = "SELECT IdHistorialCompra, IdCompra, IdProveedor, FechaCompra, CantidadComprada, PrecioUnidad, IdEmpleado FROM HistorialCompras";
                SqlCommand comando = new SqlCommand(query, conexion);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistorialCompra historial = new HistorialCompra
                        {
                            IdHistorialCompra = reader.GetInt32(0),
                            IdCompra = reader.GetInt32(1),
                            IdProveedor = reader.GetInt32(2),
                            FechaCompra = reader.GetDateTime(3),
                            CantidadComprada = reader.GetInt32(4),
                            PrecioUnidad = reader.GetDecimal(5),
                            IdEmpleado = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
                        };
                        lista.Add(historial);
                    }
                }
                conexion.Close();
                return lista;
            }
        }

        //-------------------------------------------------------------Buscar registros del historial de compras por IdCompra
        public static List<HistorialCompra> BuscarHistorialComprasPorIdCompra(int idCompra)
        {
            List<HistorialCompra> lista = new List<HistorialCompra>();

            using (SqlConnection conexion = LogicaCompartida.DataAccess.Conexion.ObtenerConexion())
            {
               
                string query = "SELECT IdHistorialCompra, IdCompra, IdProveedor, FechaCompra, CantidadComprada, PrecioUnidad, IdEmpleado FROM HistorialCompras WHERE IdCompra = @IdCompra";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdCompra", idCompra);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistorialCompra historial = new HistorialCompra
                        {
                            IdHistorialCompra = reader.GetInt32(0),
                            IdCompra = reader.GetInt32(1),
                            IdProveedor = reader.GetInt32(2),
                            FechaCompra = reader.GetDateTime(3),
                            CantidadComprada = reader.GetInt32(4),
                            PrecioUnidad = reader.GetDecimal(5),
                            IdEmpleado = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
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
