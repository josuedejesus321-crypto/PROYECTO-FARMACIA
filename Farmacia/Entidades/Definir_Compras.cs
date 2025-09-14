using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Definir_Compras
    {
        public class Compras
        {
            public int IdCompra { get; set; }
            public int IdProveedor { get; set; }
            public DateTime FechaCompra { get; set; }
            public int IdMedicamento { get; set; }
            public int CantidadComprada { get; set; }
            public decimal PrecioUnidad { get; set; }

            public Compras() { }

            public Compras(int idProveedor, DateTime fechaCompra, int idMedicamento, int cantidadComprada, decimal precioUnidad)
            {
                this.IdProveedor = idProveedor;
                this.FechaCompra = fechaCompra;
                this.IdMedicamento = idMedicamento;
                this.CantidadComprada = cantidadComprada;
                this.PrecioUnidad = precioUnidad;
            }
        }



    }


        
    
}
