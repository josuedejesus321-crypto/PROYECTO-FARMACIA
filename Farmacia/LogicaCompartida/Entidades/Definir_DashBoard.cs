using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCompartida.Entidades
{
    public class DashBoardInfo
    {
        public int CantidadFueraDeStock { get; set; }
        public int CantidadClientes { get; set; }
        public int CantidadProveedores { get; set; }
        public int CantidadMedicamentos { get; set; }
        

        public DashBoardInfo() { }

        public DashBoardInfo(int cantidadFueraDeStock, int cantidadClientes, int cantidadProveedores, int cantidadMedicamentos)
        {
            CantidadFueraDeStock = cantidadFueraDeStock;
            CantidadClientes = cantidadClientes;
            CantidadProveedores = cantidadProveedores;
            CantidadMedicamentos = cantidadMedicamentos;
        }
    }
}
