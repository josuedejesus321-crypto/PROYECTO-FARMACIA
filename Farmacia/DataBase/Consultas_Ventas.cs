using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using static Entidades.Definir_Ventas;

namespace DataBase
{
    public class Consultas_Ventas
    {
        
        public class VentasDAL
        {
            //--------------------------------------------------------Agregar Ventas
            public static int Agregar_DetalleVenta(DetalleVenta detalle)
            {
                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "EXEC SP_insertar_datos_detalleventa " +
                                   "@IdVenta, @IdMedicamento, @Cantidad, @PrecioUnitario";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // ¡AGREGAR LOS PARÁMETROS PARA EVITAR INYECCIÓN SQL Y PASAR LOS VALORES!
                    comando.Parameters.AddWithValue("@IdVenta", detalle.IdVenta);
                    comando.Parameters.AddWithValue("@IdMedicamento", detalle.IdMedicamento);
                    comando.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    comando.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                    
                    retorna = comando.ExecuteNonQuery();
                    
                }
                return retorna;
            }


            //-------------------------------------------------------------presentar registros
            public static List<DetalleVenta> PresentaRegistroDetalleVenta()
            {
                List<DetalleVenta> Lista = new List<DetalleVenta>();

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT IdDetalle, IdVenta, IdMedicamento, Cantidad, PrecioUnitario FROM DetalleVenta";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DetalleVenta detalle = new DetalleVenta();
                            detalle.IdDetalle = reader.GetInt32(0);
                            detalle.IdVenta = reader.GetInt32(1);   
                            detalle.IdMedicamento = reader.GetInt32(2);
                            detalle.Cantidad = reader.GetInt32(3);    
                            detalle.PrecioUnitario = reader.GetDecimal(4); 

                            Lista.Add(detalle);
                        }
                    }
                    conexion.Close();
                    return Lista;
                }
            }

            //-----------------------------------------------metodo para modificar la tabla
            public static int Modificar_DetalleVenta(DetalleVenta detalle)
            {
                int result = 0;
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "UPDATE DetalleVenta SET " +
                                   "IdVenta = @IdVenta, " +
                                   "IdMedicamento = @IdMedicamento, " +
                                   "Cantidad = @Cantidad, " +
                                   "PrecioUnitario = @PrecioUnitario " +
                                   "WHERE IdDetalle = @IdDetalle"; 

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@IdVenta", detalle.IdVenta);
                    comando.Parameters.AddWithValue("@IdMedicamento", detalle.IdMedicamento);
                    comando.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    comando.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);
                    comando.Parameters.AddWithValue("@IdDetalle", detalle.IdDetalle);

                    
                    result = comando.ExecuteNonQuery();
                    
                }
                return result;
            }

            //----------------------------------------Eliminar VEntas
            public static int Eliminar_DetalleVenta(int IDDetalle)
            {
                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "DELETE FROM DetalleVenta WHERE IdDetalle = @IdDetalle";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@IdDetalle", IDDetalle);

                    
                    retorna = comando.ExecuteNonQuery();
                    conexion.Close();
                }

                return retorna;
            }

            //----------------------------Buscar
            public static List<DetalleVenta> BuscarDetalleVentaPorIdVenta(string idTexto)
            {
                List<DetalleVenta> lista = new List<DetalleVenta>();
                int idVentaABuscar;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT IdDetalle, IdVenta, IdMedicamento, Cantidad, PrecioUnitario FROM DetalleVenta WHERE IdVenta = @IdVenta";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    
                    if (int.TryParse(idTexto, out idVentaABuscar))
                    {
                        comando.Parameters.AddWithValue("@IdVenta", idVentaABuscar);
                    }
                    else
                    {
                        // Si no es un entero válido, devolvemos una lista vacia
                        return lista;
                    }

                    
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DetalleVenta detalle = new DetalleVenta
                            {
                                IdDetalle = reader.GetInt32(0),
                                IdVenta = reader.GetInt32(1),
                                IdMedicamento = reader.GetInt32(2),
                                Cantidad = reader.GetInt32(3),
                                PrecioUnitario = reader.GetDecimal(4)
                            };
                            lista.Add(detalle);
                        }
                    }
                    conexion.Close();
                }
                return lista;
            }

        }
    }
}
