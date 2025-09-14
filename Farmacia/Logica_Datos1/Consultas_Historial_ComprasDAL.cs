using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataBase;

namespace Logica_Datos1
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