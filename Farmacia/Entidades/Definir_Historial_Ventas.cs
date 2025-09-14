using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Definir_Historial_Ventas
    {
        public class Historial_Ventas
        {
            public int IdHistorialVenta { get; set; }
            public int IdVenta { get; set; }
            public int IdEmpleado { get; set; }
            public DateTime FechaVenta { get; set; }
            public string NombreMedicamento { get; set; }
            public int CantidadVendida { get; set; }
            public int IdMedicamento { get; set; }

            // ¡Nuevas propiedades añadidas!
            public decimal PrecioUnitario { get; set; } // Agregado para el precio por unidad
            public decimal Total { get; set; }

            public Historial_Ventas() { }

            public Historial_Ventas(int idVenta, int idEmpleado, DateTime fechaVenta, string nombreMedicamento, int cantidadVendida, int idMedicamento, decimal precioUnitario, decimal total)
            {
                IdVenta = idVenta;
                IdEmpleado = idEmpleado;
                FechaVenta = fechaVenta;
                NombreMedicamento = nombreMedicamento;
                CantidadVendida = cantidadVendida;
                IdMedicamento = idMedicamento;
                PrecioUnitario = precioUnitario;
                Total = total;
            }
        }



    }


        
    
}
