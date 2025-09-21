using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;

namespace LogicaCompartida.Services
{
    public class HistorialCompraBLL 
    {
        public List<HistorialCompra> ObtenerTodoElHistorialCompras()
        {
            return Consultas_Historial_Compras.ObtenerTodoElHistorialCompras();
        }

        public List<HistorialCompra> ObtenerHistorialComprasPorIdCompra(int idCompra)
        {
            return Consultas_Historial_Compras.BuscarHistorialComprasPorIdCompra(idCompra);
        }

        
    }
}
