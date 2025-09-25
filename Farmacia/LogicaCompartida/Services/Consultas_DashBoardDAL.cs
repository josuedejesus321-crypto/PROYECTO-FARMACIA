using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCompartida.DataAccess;
using LogicaCompartida.Entidades;

namespace LogicaCompartida.Services
{
    public class DashBoardBLL
    {
        public DashBoardInfo ObtenerInformacionDashBoard()
        {
            DashBoardInfo info = new DashBoardInfo();
            info.CantidadClientes = Consultas_DashBoard.ObtenerCantidadClientes();
            info.CantidadProveedores = Consultas_DashBoard.ObtenerCantidadProveedores();
            info.CantidadFueraDeStock = Consultas_DashBoard.ObtenerCantidadFueraDeStock();
            info.CantidadMedicamentos = Consultas_DashBoard.ObtenerCantidadMedicamentos();
            return info;
        }
    }
}
