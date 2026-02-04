using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.Definir_Medicamentos;
using SelectPdf;


namespace FarmaciaWeb.Controllers
{
    public class MedicamentosController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var medicamentos = Consultas_Medicamentos.MedicamentosDAL.PresentaRegistro();
                return View(medicamentos);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar los medicamentos: " + ex.Message;
                return View(new List<Medicamentos>());
            }
        }

        public IActionResult Create()
        {
            // Cargar proveedores para el dropdown
            var proveedores = Consultas_Proveedores.ProveedoresDAL.PresentaRegistroProveedores();
            ViewBag.Proveedores = new SelectList(proveedores, "IdProveedor", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medicamentos medicamento)
        {
            // Volver a cargar proveedores en caso de error
            var proveedores = Consultas_Proveedores.ProveedoresDAL.PresentaRegistroProveedores();
            ViewBag.Proveedores = new SelectList(proveedores, "IdProveedor", "Nombre");

            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Medicamentos.MedicamentosDAL.Agregar_Medicamento(medicamento);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Medicamento agregado exitosamente";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Error = "No se pudo agregar el medicamento";
                    }
                }
                return View(medicamento);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al crear el medicamento: " + ex.Message;
                return View(medicamento);
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var medicamentos = Consultas_Medicamentos.MedicamentosDAL.PresentaRegistro();
                var medicamento = medicamentos.FirstOrDefault(m => m.IdMedicamento == id);
                if (medicamento == null)
                {
                    return NotFound();
                }

                // Cargar proveedores para el dropdown
                var proveedores = Consultas_Proveedores.ProveedoresDAL.PresentaRegistroProveedores();
                ViewBag.Proveedores = new SelectList(proveedores, "IdProveedor", "Nombre", medicamento.IdProveedor);

                return View(medicamento);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar el medicamento: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Medicamentos medicamento)
        {
            // Volver a cargar proveedores en caso de error
            var proveedores = Consultas_Proveedores.ProveedoresDAL.PresentaRegistroProveedores();
            ViewBag.Proveedores = new SelectList(proveedores, "IdProveedor", "Nombre", medicamento.IdProveedor);

            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Medicamentos.MedicamentosDAL.Modificar_Medicamento(medicamento);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Medicamento actualizado exitosamente";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Error = "No se pudo actualizar el medicamento";
                    }
                }
                return View(medicamento);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al actualizar el medicamento: " + ex.Message;
                return View(medicamento);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                int resultado = Consultas_Medicamentos.MedicamentosDAL.Eliminar_Medicamento(id);
                if (resultado > 0)
                {
                    TempData["Success"] = "Medicamento eliminado exitosamente";
                }
                else
                {
                    TempData["Error"] = "No se pudo eliminar el medicamento";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al eliminar el medicamento: " + ex.Message;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string searchTerm)
        {
            try
            {
                List<Medicamentos> medicamentos;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    medicamentos = Consultas_Medicamentos.MedicamentosDAL.PresentaRegistro();
                }
                else
                {
                    medicamentos = Consultas_Medicamentos.MedicamentosDAL.BuscarMedicamentosPorNombre(searchTerm);
                }
                ViewBag.SearchTerm = searchTerm;
                return View("Index", medicamentos);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error en la búsqueda: " + ex.Message;
                return View("Index", new List<Medicamentos>());
            }
        }
    }
}
