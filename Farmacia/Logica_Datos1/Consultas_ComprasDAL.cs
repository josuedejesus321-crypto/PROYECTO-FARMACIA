using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataBase;
using static Entidades.Definir_Compras;
using static DataBase.Consultas_Compras; 

namespace Logica_Datos1
{
    
    public class Consultas_ComprasDAL
    {
        public class ComprasBLL
        {
            public List<Compras> ObtenerTodosLasCompras()
            {
                return ComprasDAL.PresentaRegistroCompras(); // Llama al método estático de la clase Consultas_Ventas
            }

            public int AgregarNuevaCompra(Compras compras)
            {
                // Aquí llamamos al método estático de la capa de datos para agregar detalle de venta
                return ComprasDAL.Agregar_CompraItem(compras); 
            }

            public int EliminarCompra(int IDCompra)
            {
                // Aquí llamamos al método estático de la capa de datos para eliminar detalle de venta
                return ComprasDAL.Eliminar_Compra(IDCompra);
            }

            public int ActualizarCompra(Compras compras)
            {
                // Aquí llamamos al método estático de la capa de datos para modificar detalle de venta
                return ComprasDAL.Modificar_Compra(compras);
            }

            public List<Compras> ObtenerCompraPorIdCompra(string idCompra)
            {
                // Aquí llamamos al método estático de la capa de datos para buscar por IdVenta
                return ComprasDAL.BuscarComprasPorIdCompra(idCompra);
            }
        }
    }
}