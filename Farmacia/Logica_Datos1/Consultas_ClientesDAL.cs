using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataBase;
using static DataBase.Consultas_Clientes; 

namespace Logica_Datos1
{

    public class Consultas_ClientesDAL 
    {
        public class ClienteBLL 
        {
            public List<Definir_Clientes.Cliente> ObtenerTodosLosClientes()
            {
                return ClientesDAL.PresentaRegistroClientes(); // Usa ClientesDAL
            }

            public int AgregarNuevoCliente(Definir_Clientes.Cliente cliente)
            {
                // Aquí llamamos al método estático de la capa de datos para agregar cliente
                return ClientesDAL.Agregar_Cliente(cliente); 
            }

            public int EliminarCliente(int idCliente)
            {
                // Aquí llamamos al método estático de la capa de datos para eliminar cliente
                return ClientesDAL.Eliminar_Cliente(idCliente); 
            }

            public int ActualizarCliente(Definir_Clientes.Cliente cliente)
            {
                // Aquí llamamos al método estático de la capa de datos para modificar cliente
                return ClientesDAL.Modificar_Cliente(cliente); 
            }

            public List<Definir_Clientes.Cliente> ObtenerClientesPorNombre(string nombreCliente)
            {
                // Aquí llamamos al método estático de la capa de datos para buscar por nombre
                return ClientesDAL.BuscarClientesPorNombre(nombreCliente);
            }
        }
    }
}