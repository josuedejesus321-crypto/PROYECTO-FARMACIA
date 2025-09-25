using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using static Entidades.Definir_Proveedores;

namespace DataBase
{
    public class Consultas_Proveedores
    {
        
        public class ProveedoresDAL
        {
            //--------------------------------------------------------Agregar Proveedor
            public static int Agregar_Proveedor(Proveedores proveedor)
            {
                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "EXEC SP_insertar_datos_proveedor " +
                                   "@Nombre, @Telefono, @Direccion, @Email";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    
                    comando.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                    comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                    comando.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                    comando.Parameters.AddWithValue("@Email", proveedor.Email);

                    retorna = comando.ExecuteNonQuery();
                }
                return retorna;
            }


            //-------------------------------------------------------------presentar registros
            public static List<Proveedores> PresentaRegistroProveedores()
            {
                List<Proveedores> Lista = new List<Proveedores>();

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT IdProveedor, Nombre, Telefono, Direccion, Email FROM Proveedores";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Proveedores proveedor = new Proveedores();
                            proveedor.IdProveedor = reader.GetInt32(0);
                            proveedor.Nombre = reader.GetString(1);
                            proveedor.Telefono = reader.GetString(2);
                            proveedor.Direccion = reader.GetString(3);
                            proveedor.Email = reader.GetString(4);

                            Lista.Add(proveedor);
                        }
                    }
                    conexion.Close();
                    return Lista;
                }
            }

            //-----------------------------------------------metodo para modificar la tabla
            public static int Modificar_Proveedor(Proveedores proveedor)
            {
                int result = 0;
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "UPDATE Proveedores SET " +
                                   "Nombre = @Nombre, " +
                                   "Telefono = @Telefono, " +
                                   "Direccion = @Direccion, " +
                                   "Email = @Email " +
                                   "WHERE IdProveedor = @IdProveedor";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                    comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                    comando.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                    comando.Parameters.AddWithValue("@Email", proveedor.Email);
                    comando.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);

                    result = comando.ExecuteNonQuery();
                }
                return result;
            }

            //----------------------------------------Eliminar Proveedor
            public static int Eliminar_Proveedor(int idProveedorAEliminar)
            {
                int retorna = 0;

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "DELETE FROM Proveedores WHERE IdProveedor = @IdProveedor";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@IdProveedor", idProveedorAEliminar); 

                    retorna = comando.ExecuteNonQuery();
                }

                return retorna;
            }

            //----------------------------Buscar
            public static List<Proveedores> BuscarProveedoresPorNombre(string nombreTexto)
            {
                List<Proveedores> lista = new List<Proveedores>();

                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    
                    string query = "SELECT IdProveedor, Nombre, Telefono, Direccion, Email FROM Proveedores WHERE Nombre LIKE @Nombre OR CAST(IdProveedor AS VARCHAR) LIKE @IdProveedor";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", "%" + nombreTexto + "%");
                    comando.Parameters.AddWithValue("@IdProveedor", "%" + nombreTexto + "%");

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Proveedores proveedor = new Proveedores
                            {
                                IdProveedor = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Telefono = reader.GetString(2),
                                Direccion = reader.GetString(3),
                                Email = reader.GetString(4)
                            };
                            lista.Add(proveedor);
                        }
                    }
                    conexion.Close();
                }
                return lista;
            }

        }
    }
}
