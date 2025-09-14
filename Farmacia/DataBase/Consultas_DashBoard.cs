using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;


namespace DataBase
{
    public class Consultas_DashBoard
    {
        public static int ObtenerCantidadClientes()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                
                string query = "SELECT COUNT(*) FROM Clientes"; 
                SqlCommand comando = new SqlCommand(query, conexion);
                return (int)comando.ExecuteScalar();
            }
        }

        public static int ObtenerCantidadProveedores()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                
                string query = "SELECT COUNT(*) FROM Proveedores";
                SqlCommand comando = new SqlCommand(query, conexion);
                return (int)comando.ExecuteScalar();
            }
        }

        public static int ObtenerCantidadFueraDeStock()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                
                string query = "SELECT COUNT(*) FROM Medicamentos WHERE Stock <= 0";
                SqlCommand comando = new SqlCommand(query, conexion);
                return (int)comando.ExecuteScalar();
            }
        }

        public static int ObtenerCantidadMedicamentos()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                
                string query = "SELECT COUNT(*) FROM Medicamentos"; 
                SqlCommand comando = new SqlCommand(query, conexion);
                return (int)comando.ExecuteScalar();
            }
        }

        
    }
}