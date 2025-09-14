using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using static Entidades.Definir_Compras;


namespace DataBase
{
    public class Consultas_Compras
    {
        
        public class ComprasDAL
        {
            //--------------------------------------------------------Agregar Compras
            public static int Agregar_CompraItem(Compras compra)
            {
                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "INSERT INTO Compras (IdProveedor, FechaCompra, IdMedicamento, CantidadComprada, PrecioUnidad) " +
                                   "VALUES (@IdProveedor, @FechaCompra, @IdMedicamento, @CantidadComprada, @PrecioUnidad)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    
                    comando.Parameters.AddWithValue("@IdProveedor", compra.IdProveedor);
                    comando.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                    comando.Parameters.AddWithValue("@IdMedicamento", compra.IdMedicamento);
                    comando.Parameters.AddWithValue("@CantidadComprada", compra.CantidadComprada);
                    comando.Parameters.AddWithValue("@PrecioUnidad", compra.PrecioUnidad);       
                    retorna = comando.ExecuteNonQuery();
                }
                return retorna;
            }


            //-------------------------------------------------------------presentar registros
            public static List<Compras> PresentaRegistroCompras()
            {
                List<Compras> Lista = new List<Compras>();

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT IdCompra, IdProveedor, FechaCompra, IdMedicamento, CantidadComprada, PrecioUnidad FROM Compras";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Compras compra = new Compras();
                            compra.IdCompra = reader.GetInt32(0);
                            compra.IdProveedor = reader.GetInt32(1);
                            compra.FechaCompra = reader.GetDateTime(2);
                            compra.IdMedicamento = reader.GetInt32(3);
                            compra.CantidadComprada = reader.GetInt32(4);
                            compra.PrecioUnidad = reader.GetDecimal(5);

                            Lista.Add(compra);
                        }
                    }
                    conexion.Close();
                    return Lista;
                }
            }

            //-----------------------------------------------metodo para modificar la tabla
            public static int Modificar_Compra(Compras compra)
            {
                int result = 0;
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open(); 
                    string query = "UPDATE Compras SET " +
                                   "IdProveedor = @IdProveedor, " +
                                   "FechaCompra = @FechaCompra, " +
                                   "IdMedicamento = @IdMedicamento, " +
                                   "CantidadComprada = @CantidadComprada, " +
                                   "PrecioUnidad = @PrecioUnidad " +
                                   "WHERE IdCompra = @IdCompra";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@IdProveedor", compra.IdProveedor);
                    comando.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                    comando.Parameters.AddWithValue("@IdMedicamento", compra.IdMedicamento);
                    comando.Parameters.AddWithValue("@CantidadComprada", compra.CantidadComprada);
                    comando.Parameters.AddWithValue("@PrecioUnidad", compra.PrecioUnidad);
                    comando.Parameters.AddWithValue("@IdCompra", compra.IdCompra);

                    result = comando.ExecuteNonQuery();
                }
                return result;
            }

            //----------------------------------------Eliminar Compra
            public static int Eliminar_Compra(int idCompra)
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    SqlTransaction transaction = conexion.BeginTransaction();
                    int filasAfectadas = 0;

                    try
                    {
                        // 1. Eliminar los registros relacionados en HistorialCompras
                        string deleteHistorialQuery = "DELETE FROM HistorialCompras WHERE IdCompra = @IdCompra";
                        using (SqlCommand comandoHistorial = new SqlCommand(deleteHistorialQuery, conexion, transaction))
                        {
                            comandoHistorial.Parameters.AddWithValue("@IdCompra", idCompra);
                            comandoHistorial.ExecuteNonQuery();
                        }

                        // 2. Eliminar la compra de la tabla Compras
                        string deleteComprasQuery = "DELETE FROM Compras WHERE IdCompra = @IdCompra";
                        using (SqlCommand comandoCompras = new SqlCommand(deleteComprasQuery, conexion, transaction))
                        {
                            comandoCompras.Parameters.AddWithValue("@IdCompra", idCompra);
                            filasAfectadas = comandoCompras.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (SqlException ex) // Capturar excepciones específicas de SQL
                    {
                        transaction.Rollback();
                        // Lanzar una excepción personalizada o la excepción original para que la capa superior la maneje
                        throw new Exception($"Error al eliminar la compra en la base de datos: {ex.Message}", ex);
                    }
                    finally
                    {
                        conexion.Close();
                    }

                    return filasAfectadas;
                }
            }

            //----------------------------Buscar
            public static List<Compras> BuscarComprasPorIdCompra(string idCompra)
            {
                List<Compras> lista = new List<Compras>();
                int idCompraABuscar;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "SELECT IdCompra, IdProveedor, FechaCompra, IdMedicamento, CantidadComprada, PrecioUnidad FROM Compras WHERE IdCompra = @IdCompra";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    if (int.TryParse(idCompra, out idCompraABuscar))
                    {
                        comando.Parameters.AddWithValue("@IdCompra", idCompraABuscar);
                    }
                    else
                    {
                        
                        return lista;
                    }

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Compras compra = new Compras
                            {
                                IdCompra = reader.GetInt32(0),
                                IdProveedor = reader.GetInt32(1),
                                FechaCompra = reader.GetDateTime(2),
                                IdMedicamento = reader.GetInt32(3),
                                CantidadComprada = reader.GetInt32(4),
                                PrecioUnidad = reader.GetDecimal(5)
                            };
                            lista.Add(compra);
                        }
                    }
                    conexion.Close();
                }
                return lista;
            }

        }
    }
}
