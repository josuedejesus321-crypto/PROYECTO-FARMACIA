using Microsoft.AspNetCore.Mvc;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.Definir_Compras;
using SelectPdf;

namespace FarmaciaWeb.Controllers
{
    public class ComprasController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var compras = Consultas_Compras.ComprasDAL.PresentaRegistroCompras();
                return View(compras);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar las compras: " + ex.Message;
                return View(new List<Compras>());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Compras compra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Compras.ComprasDAL.Agregar_CompraItem(compra);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Compra agregada exitosamente";
                        return RedirectToAction("Index");
                    }
                }
                return View(compra);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al crear el compra: " + ex.Message;
                return View(compra);
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var compras = Consultas_Compras.ComprasDAL.PresentaRegistroCompras();
                var compra = compras.FirstOrDefault(c => c.IdCompra == id);
                if (compra == null)
                {
                    return NotFound();
                }
                return View(compra);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar la compra: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Compras compras)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Compras.ComprasDAL.Modificar_Compra(compras);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Compra actualizada exitosamente";
                        return RedirectToAction("Index");
                    }
                }
                return View(compras);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al actualizar el cliente: " + ex.Message;
                return View(compras);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                int resultado = Consultas_Compras.ComprasDAL.Eliminar_Compra(id);
                if (resultado > 0)
                {
                    TempData["Success"] = "Compra eliminada exitosamente";
                }
                else
                {
                    TempData["Error"] = "No se pudo eliminar la compra";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al eliminar la compra: " + ex.Message;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string searchTerm)
        {
            try
            {
                List<Compras> compras;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    compras = Consultas_Compras.ComprasDAL.PresentaRegistroCompras();
                }
                else
                {
                    compras = Consultas_Compras.ComprasDAL.BuscarComprasPorIdCompra(searchTerm);
                }
                ViewBag.SearchTerm = searchTerm;
                return View("Index", compras);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error en la búsqueda: " + ex.Message;
                return View("Index", new List<Compras>());
            }
        }
    }
}