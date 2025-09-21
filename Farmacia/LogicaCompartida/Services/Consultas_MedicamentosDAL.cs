using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.Definir_Medicamentos;
using static LogicaCompartida.Services.Consultas_MedicamentosDAL;
using static LogicaCompartida.DataAccess.Consultas_Medicamentos;

namespace LogicaCompartida.Services
{
    //aqui se pasa el metodo para consultar desde LA BASE DE DATOS
    public class Consultas_MedicamentosDAL
    {
        public class MedicamentosBLL
        {
            public List<Medicamentos> ObtenerTodosLosMedicamentos()
            {
                return MedicamentosDAL.PresentaRegistro(); // Llama al método estático por el nombre de la clase
            }

            public int AgregarNuevoMedicamento(Medicamentos medicamento)
            {
                // Aquí simplemente llamamos al método estático de la capa de datos
                return MedicamentosDAL.Agregar_Medicamento(medicamento);
            }

            public int EliminarNuevoMedicamento(int IDMedicamento)
            {
                // Aquí simplemente llamamos al método estático de la capa de datos
                return LogicaCompartida.DataAccess.Consultas_Medicamentos.MedicamentosDAL.Eliminar_Medicamento(IDMedicamento);
            }

            public int ActualizarMedicamento(Medicamentos medicamento)
            {
                // Aquí llamamos al método estático de la capa de datos para modificar
                return MedicamentosDAL.Modificar_Medicamento(medicamento);
            }

            public List<Medicamentos> ObtenerMedicamentosPorNombre(string nombre)
            {
                // Aquí llamamos al método estático de la capa de datos para buscar por nombre
                return MedicamentosDAL.BuscarMedicamentosPorNombre(nombre);
            }

            public static Medicamentos ObtenerMedicamentosPorCodigo(string ID)
            {
                // Llama al método de la capa de datos que devuelve un solo objeto Medicamentos.
                return MedicamentosDAL.BuscarMedicamentoPorCodigo(ID);
            }
        }
    }
}
