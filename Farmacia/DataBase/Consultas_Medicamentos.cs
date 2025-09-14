using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using static Entidades.Definir_Medicamentos;

namespace DataBase
{
    public class Consultas_Medicamentos
    {
        
        public class MedicamentosDAL
        {
            //--------------------------------------------------------Agregar Medicamentos
            public static int Agregar_Medicamento(Medicamentos Medicamentos)
            {

                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {

                    string query = "EXEC SP_insertar_datos_medicamento " +
                        "@Nombre, @NombreGenerico, @Categoria, @Estante, " +
                        "@PrecioVenta, @PrecioProveedor,@Stock, @IdProveedor";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // ¡AGREGAR LOS PARÁMETROS PARA EVITAR INYECCIÓN SQL Y PASAR LOS VALORES!
                    comando.Parameters.AddWithValue("@Nombre", Medicamentos.Nombre);
                    comando.Parameters.AddWithValue("@NombreGenerico", Medicamentos.NombreGenerico);
                    comando.Parameters.AddWithValue("@Categoria", Medicamentos.Categoria);
                    comando.Parameters.AddWithValue("@Estante", Medicamentos.Estante);
                    comando.Parameters.AddWithValue("@PrecioVenta", Medicamentos.PrecioVenta);
                    comando.Parameters.AddWithValue("@PrecioProveedor", Medicamentos.PrecioProveedor);
                    comando.Parameters.AddWithValue("@Stock", Medicamentos.Stock);
                    comando.Parameters.AddWithValue("@IdProveedor", Medicamentos.IdProveedor);


                    
                    retorna = comando.ExecuteNonQuery();
                }

                return retorna;
            }

            //-------------------------------------------------------------presentar registros
            public static List<Medicamentos> PresentaRegistro()
            {
                List<Medicamentos> Lista = new List<Medicamentos>();

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "select * from Medicamentos";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Medicamentos med = new Medicamentos();
                        med.IdMedicamento = reader.GetInt32(0);//los numeros son las posiciones que tendran
                        med.Nombre = reader.GetString(1);
                        med.NombreGenerico = reader.GetString(2);
                        med.Categoria = reader.GetString(3);
                        med.Estante = reader.GetString(4);
                        med.PrecioVenta = reader.GetDecimal(5);
                        med.PrecioProveedor = reader.GetDecimal(6);
                        med.Stock = reader.GetInt32(7);
                        med.IdProveedor = reader.GetInt32(8);
                        

                        Lista.Add(med);

                    }
                    conexion.Close();
                    return Lista;

                }



            }

            //-----------------------------------------------metodo para modificar la tabla
            public static int Modificar_Medicamento(Medicamentos medicamentos)
            {
                int result = 0;
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "UPDATE Medicamentos SET " +
                       "Nombre = @Nombre, " +
                       "NombreGenerico = @NombreGenerico, " +
                       "Categoria = @Categoria, " +
                       "Estante = @Estante, " +
                       "PrecioVenta = @PrecioVenta, " +
                       "PrecioProveedor = @PrecioProveedor, " +
                       "Stock = @Stock, " +
                       "IdProveedor = @IdProveedor " +
                       "WHERE IdMedicamento = @IdMedicamento";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@Nombre", medicamentos.Nombre);
                    comando.Parameters.AddWithValue("@NombreGenerico", medicamentos.NombreGenerico);
                    comando.Parameters.AddWithValue("@Categoria", medicamentos.Categoria);
                    comando.Parameters.AddWithValue("@Estante", medicamentos.Estante);
                    comando.Parameters.AddWithValue("@PrecioVenta", medicamentos.PrecioVenta);
                    comando.Parameters.AddWithValue("@PrecioProveedor", medicamentos.PrecioProveedor);
                    comando.Parameters.AddWithValue("@Stock", medicamentos.Stock);
                    comando.Parameters.AddWithValue("@IdProveedor", medicamentos.IdProveedor);
                    comando.Parameters.AddWithValue("@IdMedicamento", medicamentos.IdMedicamento);

                    result = comando.ExecuteNonQuery();
                    conexion.Close();
                }
                return result;
            }

            //----------------------------------------Eliminar medicamento
            public static int Eliminar_Medicamento(int IDMedicamento)
            {

                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {

                    string query = "Delete from Medicamentos where IdMedicamento=" + IDMedicamento + " ";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    retorna = comando.ExecuteNonQuery();
                }

                return retorna;
            }

            //----------------------------Buscar
            public static List<Medicamentos> BuscarMedicamentosPorNombre(string nombre)
            {
                List<Medicamentos> lista = new List<Medicamentos>();

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT * FROM Medicamentos WHERE Nombre LIKE @Nombre OR IdMedicamento LIKE @IdMedicamento";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    
                    comando.Parameters.AddWithValue("@Nombre", "%" + nombre + "%"); // Busca nombres que contengan el texto
                    comando.Parameters.AddWithValue("@IdMedicamento", "%" + nombre + "%");

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Medicamentos medicamento = new Medicamentos
                            {
                                IdMedicamento = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                NombreGenerico = reader.GetString(2),
                                Categoria = reader.GetString(3),
                                Estante = reader.GetString(4),
                                PrecioVenta = reader.GetDecimal(5),
                                PrecioProveedor = reader.GetDecimal(6),
                                Stock = reader.GetInt32(7),
                                IdProveedor = reader.GetInt32(8)
                            };
                            lista.Add(medicamento);
                        }
                    }
                    conexion.Close();
                }
                return lista;
            }

            //consulta para el escaner
            public static Medicamentos BuscarMedicamentoPorCodigo(string ID)
            {
                Medicamentos medicamentoEncontrado = null;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    // 1. Usa '=' para una búsqueda exacta en el campo IdMedicamento
                    string query = "SELECT * FROM Medicamentos WHERE IdMedicamento = @IdMedicamento";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    // 2. Asigna el valor del código de barras al parámetro sin comodines
                    comando.Parameters.AddWithValue("@IdMedicamento", ID);

                    

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        // 3. Lee solo la primera fila, ya que el ID es único
                        if (reader.Read())
                        {
                            medicamentoEncontrado = new Medicamentos
                            {
                                IdMedicamento = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                NombreGenerico = reader.GetString(2),
                                Categoria = reader.GetString(3),
                                Estante = reader.GetString(4),
                                PrecioVenta = reader.GetDecimal(5),
                                PrecioProveedor = reader.GetDecimal(6),
                                Stock = reader.GetInt32(7),
                                IdProveedor = reader.GetInt32(8)
                            };
                        }
                    }
                } 

                // 4. Retorna el medicamento encontrado o null si no se halló.
                return medicamentoEncontrado;
            }

        }
    }
}
