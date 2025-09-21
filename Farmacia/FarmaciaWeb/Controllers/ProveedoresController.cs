using Microsoft.AspNetCore.Mvc;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.Definir_Proveedores;

namespace FarmaciaWeb.Controllers
{
    public class ProveedoresController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var proveedores = Consultas_Proveedores.ProveedoresDAL.PresentaRegistroProveedores();
                return View(proveedores);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar los proveedores: " + ex.Message;
                return View(new List<Proveedores>());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Proveedores proveedor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Proveedores.ProveedoresDAL.Agregar_Proveedor(proveedor);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Proveedor agregado exitosamente";
                        return RedirectToAction("Index");
                    }
                }
                return View(proveedor);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al crear el proveedor: " + ex.Message;
                return View(proveedor);
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var proveedores = Consultas_Proveedores.ProveedoresDAL.PresentaRegistroProveedores();
                var proveedor = proveedores.FirstOrDefault(p => p.IdProveedor == id);
                if (proveedor == null)
                {
                    return NotFound();
                }
                return View(proveedor);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar el proveedor: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Proveedores proveedor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Proveedores.ProveedoresDAL.Modificar_Proveedor(proveedor);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Proveedor actualizado exitosamente";
                        return RedirectToAction("Index");
                    }
                }
                return View(proveedor);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al actualizar el proveedor: " + ex.Message;
                return View(proveedor);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                int resultado = Consultas_Proveedores.ProveedoresDAL.Eliminar_Proveedor(id);
                if (resultado > 0)
                {
                    TempData["Success"] = "Proveedor eliminado exitosamente";
                }
                else
                {
                    TempData["Error"] = "No se pudo eliminar el proveedor";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al eliminar el proveedor: " + ex.Message;
            }
            return RedirectToAction("Index");
        }
    }
}