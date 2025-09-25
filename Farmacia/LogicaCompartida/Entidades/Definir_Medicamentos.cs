using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.Entidades
{
    public class Definir_Medicamentos
    {
        public class Medicamentos
        {
            public int IdMedicamento { get; set; }
            public string Nombre { get; set; }
            public string NombreGenerico { get; set; }
            public string Categoria { get; set; }
            public string Estante { get; set; }
            public decimal PrecioVenta { get; set; }
            public decimal PrecioProveedor { get; set; }
            public byte[] Imagen { get; set; }
            public int Stock { get; set; }
            public int IdProveedor { get; set; }


            public Medicamentos() { }

            public Medicamentos(string nombre, string nombreGenerico, string categoria, string estante, decimal precioVenta, decimal precioProveedor, byte[] imagen, int stock, int idProveedor)
            {
                this.Nombre = nombre;
                this.NombreGenerico = nombreGenerico;
                this.Categoria = categoria;
                this.Estante = estante;
                this.PrecioVenta = precioVenta;
                this.PrecioProveedor = precioProveedor;
                this.Imagen = imagen;
                this.Stock = stock;
                this.IdProveedor = idProveedor;



            }


        }
    }
}
