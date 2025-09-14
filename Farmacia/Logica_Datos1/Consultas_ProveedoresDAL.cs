using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataBase;
using static Entidades.Definir_Proveedores;
using static DataBase.Consultas_Proveedores; 

namespace Logica_Datos1
{
    
    public class Consultas_ProveedoresDAL
    {
        public class ProveedorBLL
        {
            public List<Proveedores> ObtenerTodosLosProveedores()
            {
                return ProveedoresDAL.PresentaRegistroProveedores();
            }

            public int AgregarNuevoProveedor(Proveedores proveedor)
            {
                // Aquí llamamos al método estático de la capa de datos para agregar proveedor
                return ProveedoresDAL.Agregar_Proveedor(proveedor);
            }

            public int EliminarProveedor(int idProveedor)
            {
                // Aquí llamamos al método estático de la capa de datos para eliminar proveedor
                return ProveedoresDAL.Eliminar_Proveedor(idProveedor);
            }

            public int ActualizarProveedor(Proveedores proveedor)
            {
                // Aquí llamamos al método estático de la capa de datos para modificar proveedor
                return ProveedoresDAL.Modificar_Proveedor(proveedor);
            }

            public List<Proveedores> ObtenerProveedoresPorNombre(string nombreProveedor)
            {
                // Aquí llamamos al método estático de la capa de datos para buscar por nombre
                return ProveedoresDAL.BuscarProveedoresPorNombre(nombreProveedor); 
            }
        }
    }
}
