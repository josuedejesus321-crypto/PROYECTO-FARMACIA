using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataBase;
using static Entidades.Definir_Historial_Ventas;
using static DataBase.Consultas_Historial_Ventas;

namespace Logica_Datos1
{
    
    public class Consultas_Historial_VentasDAL
    {
        public class HistorialVentaBLL 
        {
            public List<Historial_Ventas> ObtenerTodoElHistorialVentas()
            {
                return Consultas_Historial_Ventas.ObtenerTodoElHistorial(); 
            }

            public List<Historial_Ventas> ObtenerHistorialVentasPorIdVenta(int idVenta)
            {
                return Consultas_Historial_Ventas.BuscarHistorialPorIdVenta(idVenta); 
            }

            
        }
    }
}