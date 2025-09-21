using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using static Entidades.Definir_Clientes;

namespace DataBase
{
    public class Consultas_Clientes
    {

        public class ClientesDAL
        {
            //--------------------------------------------------------Agregar Cliente
            public static int Agregar_Cliente(Cliente cliente)
            {
                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "EXEC SP_insertar_datos_cliente " +
                                         "@Nombre, @Telefono, @Email, @Direccion";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Email", cliente.Email);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);

                    retorna = comando.ExecuteNonQuery();
                }
                return retorna;
            }


            //-------------------------------------------------------------presentar registros de clientes
            public static List<Cliente> PresentaRegistroClientes()
            {
                List<Cliente> Lista = new List<Cliente>();

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "SELECT IdCliente, Nombre, Telefono, Email, Direccion FROM Clientes";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente();
                            cliente.IdCliente = reader.GetInt32(0);
                            cliente.Nombre = reader.GetString(1);
                            cliente.Telefono = reader.GetString(2);
                            cliente.Email = reader.GetString(3);
                            cliente.Direccion = reader.GetString(4);

                            Lista.Add(cliente);
                        }
                    }
                    conexion.Close();
                    return Lista;
                }
            }

            //-----------------------------------------------metodo para modificar la tabla Clientes
            public static int Modificar_Cliente(Cliente cliente)
            {
                int result = 0;
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "UPDATE Clientes SET " +
                                         "Nombre = @Nombre, " +
                                         "Telefono = @Telefono, " +
                                         "Email = @Email, " +
                                         "Direccion = @Direccion " +
                                         "WHERE IdCliente = @IdCliente";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Email", cliente.Email);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);

                    result = comando.ExecuteNonQuery();
                }
                return result;
            }

            //----------------------------------------Eliminar Cliente
            public static int Eliminar_Cliente(int idClienteAEliminar)
            {
                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@IdCliente", idClienteAEliminar);

                    retorna = comando.ExecuteNonQuery();
                }

                return retorna;
            }

            //----------------------------Buscar Clientes por Nombre o ID
            public static List<Cliente> BuscarClientesPorNombre(string nombreTexto)
            {
                List<Cliente> lista = new List<Cliente>();

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "SELECT IdCliente, Nombre, Telefono, Email, Direccion FROM Clientes WHERE Nombre LIKE @Nombre OR CAST(IdCliente AS VARCHAR) LIKE @IdCliente";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", "%" + nombreTexto + "%");
                    comando.Parameters.AddWithValue("@IdCliente", "%" + nombreTexto + "%");

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                IdCliente = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Telefono = reader.GetString(2),
                                Email = reader.GetString(3),
                                Direccion = reader.GetString(4)
                            };
                            lista.Add(cliente);
                        }
                    }
                    conexion.Close();
                }
                return lista;
            }

        }
    }
}