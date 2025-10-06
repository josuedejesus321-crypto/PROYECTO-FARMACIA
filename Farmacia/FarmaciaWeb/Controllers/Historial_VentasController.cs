using Microsoft.AspNetCore.Mvc;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using System;
using System.Collections.Generic;
using static LogicaCompartida.Entidades.Definir_Historial_Ventas;

namespace FarmaciaWeb.Controllers
{
    public class Historial_VentasController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                // Aquí deberías llamar a la Capa BLL, si existe, si no, directo al DAL.
                var Historial_Ventas = Consultas_Historial_Ventas.ObtenerTodoElHistorial();
                return View(Historial_Ventas);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar el historial de ventas: " + ex.Message;
                // Devolvemos el tipo de entidad correcto en caso de error
                return View(new List<Historial_Ventas>());
            }
        }

        // ✅ CORRECCIÓN 1: Usar [HttpGet] para la búsqueda desde el formulario (method="get")
        [HttpGet]
        public IActionResult Search(string searchTerm)
        {
            try
            {
                // ✅ CORRECCIÓN 2: Recibir searchTerm como string
                List<Historial_Ventas> Historialventas;
                int idVentaBusqueda = 0;
                bool isNumeric = int.TryParse(searchTerm, out idVentaBusqueda);

                // Si el término de búsqueda está vacío o no es un número válido, mostrar todo
                if (string.IsNullOrWhiteSpace(searchTerm) || !isNumeric || idVentaBusqueda <= 0)
                {
                    Historialventas = Consultas_Historial_Ventas.ObtenerTodoElHistorial();
                    // Si no es numérico o está vacío, solo guardamos el texto original
                    ViewBag.SearchTerm = searchTerm;
                }
                else
                {
                    // Si es un número válido, buscar por ID de Venta
                    Historialventas = Consultas_Historial_Ventas.BuscarHistorialPorIdVenta(idVentaBusqueda);
                    ViewBag.SearchTerm = idVentaBusqueda.ToString();
                }

                return View("Index", Historialventas);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error en la búsqueda: " + ex.Message;
                return View("Index", new List<Historial_Ventas>());
            }
        }
    }
}
