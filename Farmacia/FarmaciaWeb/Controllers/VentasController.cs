using Microsoft.AspNetCore.Mvc;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.Definir_Ventas;
using SelectPdf;

namespace FarmaciaWeb.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var Ventas = Consultas_Ventas.VentasDAL.PresentaRegistroDetalleVenta();
                return View(Ventas);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar las ventass: " + ex.Message;
                return View(new List<DetalleVenta>());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DetalleVenta venta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Ventas.VentasDAL.Agregar_DetalleVenta(venta);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Venta agregada exitosamente";
                        return RedirectToAction("Index");
                    }
                }
                return View(venta);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al crear la venta: " + ex.Message;
                return View(venta);
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var ventas = Consultas_Ventas.VentasDAL.PresentaRegistroDetalleVenta();
                var detalleVenta = ventas.FirstOrDefault(v => v.IdVenta == id);
                if (ventas == null)
                {
                    return NotFound();
                }
                return View(ventas);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar las ventas: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(DetalleVenta ventas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Ventas.VentasDAL.Modificar_DetalleVenta(ventas);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Ventas actualizado exitosamente";
                        return RedirectToAction("Index");
                    }
                }
                return View(ventas);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al actualizar la venta: " + ex.Message;
                return View(ventas);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                int resultado = Consultas_Ventas.VentasDAL.Eliminar_DetalleVenta(id);
                if (resultado > 0)
                {
                    TempData["Success"] = "Venta eliminada exitosamente";
                }
                else
                {
                    TempData["Error"] = "No se pudo eliminar la venta";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al eliminar la venta: " + ex.Message;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string searchTerm)
        {
            try
            {
                List<DetalleVenta> ventas;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    ventas = Consultas_Ventas.VentasDAL.PresentaRegistroDetalleVenta();
                }
                else
                {
                    ventas = Consultas_Ventas.VentasDAL.BuscarDetalleVentaPorIdVenta(searchTerm);
                }
                ViewBag.SearchTerm = searchTerm;
                return View("Index", ventas);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error en la búsqueda: " + ex.Message;
                return View("Index", new List<DetalleVenta>());
            }
        }
    }
}