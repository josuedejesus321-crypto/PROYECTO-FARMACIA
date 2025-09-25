using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()//creamos un metodo para la conectar la base de datos
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto_Farmacia1;Data Source=DESKTOP-Q0CF1B0\\SQLEXPRESS;TrustServerCertificate=true");
            conexion.Open();

            return conexion;
        }

    }
}
