using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.Entidades
{
    public class Definir_Ventas
    {
        public class DetalleVenta
        {
            public int IdDetalle { get; set; }
            public int IdVenta { get; set; }
            public int IdMedicamento { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }

            public DetalleVenta() { }

            public DetalleVenta(int idVenta, int idMedicamento, int cantidad, decimal precioUnitario)
            {
                this.IdVenta = idVenta;
                this.IdMedicamento = idMedicamento;
                this.Cantidad = cantidad;
                this.PrecioUnitario = precioUnitario;
            }
        }


    }


        
    
}
