using Microsoft.AspNetCore.Mvc;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.HistorialCompra;

namespace FarmaciaWeb.Controllers
{
    public class Historial_ComprasController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var Historial_Compras = Consultas_Historial_Compras.ObtenerTodoElHistorialCompras();
                return View(Historial_Compras);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar los clientes: " + ex.Message;
                // ✅ CORRECCIÓN 1: Devolver la Entidad (HistorialCompra), no el DAL (Consultas_Historial_Compras)
                return View(new List<HistorialCompra>());
            }
        }

        // ✅ CORRECCIÓN 2: Cambiar [HttpPost] a [HttpGet] si el formulario de la vista usa GET.
        // Y lo más importante, cambiar el parámetro a string para recibir la entrada del usuario.
        [HttpGet]
        public IActionResult Search(string searchTerm)
        {
            try
            {
                List<HistorialCompra> historial_Compras;

                // Si el término de búsqueda está vacío o es nulo (después de Trim)
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    historial_Compras = Consultas_Historial_Compras.ObtenerTodoElHistorialCompras();
                }
                else
                {
                    int idCompra;
                    // ✅ CORRECCIÓN 3: Usar TryParse para convertir el string a int
                    if (int.TryParse(searchTerm, out idCompra))
                    {
                        // Si es un número válido, buscar por IdCompra
                        historial_Compras = Consultas_Historial_Compras.BuscarHistorialComprasPorIdCompra(idCompra);
                    }
                    else
                    {
                        // Si no es un número, puedes buscar por otro campo (si tu DAL lo soporta)
                        // o, simplemente, devolver una lista vacía.
                        historial_Compras = new List<HistorialCompra>();
                        ViewBag.Error = "Por favor, ingrese un ID de compra válido.";
                    }
                }

                // Asegúrate de que ViewBag.SearchTerm reciba el valor original para mantenerlo en el cuadro de texto
                ViewBag.SearchTerm = searchTerm;
                return View("Index", historial_Compras);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error en la búsqueda: " + ex.Message;
                // ✅ CORRECCIÓN 4: Devolver la Entidad (HistorialCompra), no el DAL (Consultas_Historial_Compras)
                return View("Index", new List<HistorialCompra>());
            }
        }
    }
}