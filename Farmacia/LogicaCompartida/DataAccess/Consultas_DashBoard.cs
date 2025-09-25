using System;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;


namespace LogicaCompartida.DataAccess
{
    public class Consultas_DashBoard
    {
        public static int ObtenerCantidadClientes()
        {
            using (SqlConnection conexion = LogicaCompartida.DataAccess.Conexion.ObtenerConexion())
            {
                
                string query = "SELECT COUNT(*) FROM Clientes"; 
                SqlCommand comando = new SqlCommand(query, conexion);
                return (int)comando.ExecuteScalar();
            }
        }

        public static int ObtenerCantidadProveedores()
        {
            using (SqlConnection conexion = LogicaCompartida.DataAccess.Conexion.ObtenerConexion())
            {
                
                string query = "SELECT COUNT(*) FROM Proveedores";
                SqlCommand comando = new SqlCommand(query, conexion);
                return (int)comando.ExecuteScalar();
            }
        }

        public static int ObtenerCantidadFueraDeStock()
        {
            using (SqlConnection conexion = LogicaCompartida.DataAccess.Conexion.ObtenerConexion())
            {
                
                string query = "SELECT COUNT(*) FROM Medicamentos WHERE Stock <= 0";
                SqlCommand comando = new SqlCommand(query, conexion);
                return (int)comando.ExecuteScalar();
            }
        }

        public static int ObtenerCantidadMedicamentos()
        {
            using (SqlConnection conexion = LogicaCompartida.DataAccess.Conexion.ObtenerConexion())
            {
                
                string query = "SELECT COUNT(*) FROM Medicamentos"; 
                SqlCommand comando = new SqlCommand(query, conexion);
                return (int)comando.ExecuteScalar();
            }
        }

        
    }
}
