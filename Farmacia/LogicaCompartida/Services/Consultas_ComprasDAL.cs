using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.Definir_Compras;
using static LogicaCompartida.DataAccess.Consultas_Compras; 

namespace LogicaCompartida.Services
{
    
    public class Consultas_ComprasDAL
    {
        public class ComprasBLL
        {
            public List<Compras> ObtenerTodosLasCompras()
            {
                return ComprasDAL.PresentaRegistroCompras(); // Llama al m�todo est�tico de la clase Consultas_Ventas
            }

            public int AgregarNuevaCompra(Compras compras)
            {
                // Aqu� llamamos al m�todo est�tico de la capa de datos para agregar detalle de venta
                return ComprasDAL.Agregar_CompraItem(compras); 
            }

            public int EliminarCompra(int IDCompra)
            {
                // Aqu� llamamos al m�todo est�tico de la capa de datos para eliminar detalle de venta
                return ComprasDAL.Eliminar_Compra(IDCompra);
            }

            public int ActualizarCompra(Compras compras)
            {
                // Aqu� llamamos al m�todo est�tico de la capa de datos para modificar detalle de venta
                return ComprasDAL.Modificar_Compra(compras);
            }

            public List<Compras> ObtenerCompraPorIdCompra(string idCompra)
            {
                // Aqu� llamamos al m�todo est�tico de la capa de datos para buscar por IdVenta
                return ComprasDAL.BuscarComprasPorIdCompra(idCompra);
            }
        }
    }
}
