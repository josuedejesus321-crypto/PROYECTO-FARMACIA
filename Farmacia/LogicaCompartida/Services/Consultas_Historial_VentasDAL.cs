using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.Definir_Historial_Ventas;
using static LogicaCompartida.DataAccess.Consultas_Historial_Ventas;

namespace LogicaCompartida.Services
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
