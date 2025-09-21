using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using static Entidades.Definir_Historial_Ventas;

namespace DataBase
{
    public class Consultas_Historial_Ventas 
    {
        //-------------------------------------------------------------Presentar registros del historial de ventas
        public static List<Historial_Ventas> ObtenerTodoElHistorial() // Renombra el método para mayor claridad
        {
            List<Historial_Ventas> lista = new List<Historial_Ventas>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                
                string query = "SELECT IdHistorialVenta,IdVenta,IdEmpleado,FechaVenta,NombreMedicamento,CantidadVendida,IdMedicamento,PrecioUnitario,Total FROM HistorialVenta;";
                SqlCommand comando = new SqlCommand(query, conexion);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Historial_Ventas historial = new Historial_Ventas
                        {
                            IdHistorialVenta = reader.GetInt32(0),
                            IdVenta = reader.GetInt32(1),
                            IdEmpleado = reader.GetInt32(2),
                            FechaVenta = reader.GetDateTime(3),
                            NombreMedicamento = reader.GetString(4),
                            CantidadVendida = reader.GetInt32(5),
                            IdMedicamento = reader.GetInt32(6),
                            PrecioUnitario = reader.GetDecimal(7),
                            Total = reader.GetDecimal(8)
                        };
                        lista.Add(historial);
                    }
                }
                conexion.Close();
                return lista;
            }
        }

        //-------------------------------------------------------------Buscar registros del historial de ventas por IdVenta
        public static List<Historial_Ventas> BuscarHistorialPorIdVenta(int idVenta) 
        {
            List<Historial_Ventas> lista = new List<Historial_Ventas>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                
                string query = "SELECT IdHistorialVenta, IdVenta, IdEmpleado, FechaVenta, NombreMedicamento, CantidadVendida, IdMedicamento,PrecioUnitario,Total FROM HistorialVenta WHERE IdVenta = @IdVenta";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdVenta", idVenta);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Historial_Ventas historial = new Historial_Ventas
                        {
                            IdHistorialVenta = reader.GetInt32(0),
                            IdVenta = reader.GetInt32(1),
                            IdEmpleado = reader.GetInt32(2),
                            FechaVenta = reader.GetDateTime(3),
                            NombreMedicamento = reader.GetString(4),
                            CantidadVendida = reader.GetInt32(5),
                            IdMedicamento = reader.GetInt32(6),
                            PrecioUnitario = reader.GetDecimal(7),
                            Total = reader.GetDecimal(8)
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