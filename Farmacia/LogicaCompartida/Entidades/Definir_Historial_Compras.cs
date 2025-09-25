using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.Entidades
{
    public class HistorialCompra
    {
        public int IdHistorialCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProveedor { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdMedicamento { get; set; }
        public int CantidadComprada { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int? IdEmpleado { get; set; } // Permite valores null

        public HistorialCompra() { }

        public HistorialCompra(int idCompra, int idProveedor, DateTime fechaCompra, int idMedicamento, int cantidadComprada, decimal precioUnidad, int? idEmpleado)
        {
            IdCompra = idCompra;
            IdProveedor = idProveedor;
            FechaCompra = fechaCompra;
            IdMedicamento = idMedicamento;
            CantidadComprada = cantidadComprada;
            PrecioUnidad = precioUnidad;
            IdEmpleado = idEmpleado;
        }
    }
}
