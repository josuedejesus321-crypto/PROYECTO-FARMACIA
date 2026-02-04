using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.DataAccess
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            string nombreEquipo = Environment.MachineName; // PC actual
            string instancia = "SQLEXPRESS"; // instancia por defecto

            string dataSource = $@"{nombreEquipo}\{instancia}";

            string connectionString = $"Integrated Security=SSPI;" +
                                      $"Persist Security Info=False;" +
                                      $"Initial Catalog=Proyecto_Farmacia1;" +
                                      $"Data Source={dataSource};" +
                                      $"TrustServerCertificate=true";

            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();

            return conexion;
        }
    }
}


