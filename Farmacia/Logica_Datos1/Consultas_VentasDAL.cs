﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataBase;
using static Entidades.Definir_Ventas;
using static DataBase.Consultas_Ventas; 

namespace Logica_Datos1
{
    
    public class Consultas_VentasDAL
    {
        public class VentasBLL
        {
            public List<DetalleVenta> ObtenerTodosLosDetallesVenta()
            {
                return VentasDAL.PresentaRegistroDetalleVenta();
            }

            public int AgregarNuevoDetalleVenta(DetalleVenta detalle)
            {
                // Aquí llamamos al método estático de la capa de datos para agregar detalle de venta
                return VentasDAL.Agregar_DetalleVenta(detalle); 
            }

            public int EliminarDetalleVenta(int IDDetalle)
            {
                // Aquí llamamos al método estático de la capa de datos para eliminar detalle de venta
                return VentasDAL.Eliminar_DetalleVenta(IDDetalle);
            }

            public int ActualizarDetalleVenta(DetalleVenta detalle)
            {
                // Aquí llamamos al método estático de la capa de datos para modificar detalle de venta
                return VentasDAL.Modificar_DetalleVenta(detalle);
            }

            public List<DetalleVenta> ObtenerDetallesVentaPorIdVenta(string idVenta)
            {
                // Aquí llamamos al método estático de la capa de datos para buscar por IdVenta
                return VentasDAL.BuscarDetalleVentaPorIdVenta(idVenta);
            }
        }
    }
}