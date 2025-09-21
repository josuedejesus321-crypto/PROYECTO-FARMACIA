using Microsoft.AspNetCore.Mvc;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
using static LogicaCompartida.Entidades.Definir_Clientes;

namespace FarmaciaWeb.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var clientes = Consultas_Clientes.ClientesDAL.PresentaRegistroClientes();
                return View(clientes);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar los clientes: " + ex.Message;
                return View(new List<Cliente>());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Clientes.ClientesDAL.Agregar_Cliente(cliente);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Cliente agregado exitosamente";
                        return RedirectToAction("Index");
                    }
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al crear el cliente: " + ex.Message;
                return View(cliente);
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var clientes = Consultas_Clientes.ClientesDAL.PresentaRegistroClientes();
                var cliente = clientes.FirstOrDefault(c => c.IdCliente == id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar el cliente: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resultado = Consultas_Clientes.ClientesDAL.Modificar_Cliente(cliente);
                    if (resultado > 0)
                    {
                        TempData["Success"] = "Cliente actualizado exitosamente";
                        return RedirectToAction("Index");
                    }
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al actualizar el cliente: " + ex.Message;
                return View(cliente);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                int resultado = Consultas_Clientes.ClientesDAL.Eliminar_Cliente(id);
                if (resultado > 0)
                {
                    TempData["Success"] = "Cliente eliminado exitosamente";
                }
                else
                {
                    TempData["Error"] = "No se pudo eliminar el cliente";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al eliminar el cliente: " + ex.Message;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string searchTerm)
        {
            try
            {
                List<Cliente> clientes;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    clientes = Consultas_Clientes.ClientesDAL.PresentaRegistroClientes();
                }
                else
                {
                    clientes = Consultas_Clientes.ClientesDAL.BuscarClientesPorNombre(searchTerm);
                }
                ViewBag.SearchTerm = searchTerm;
                return View("Index", clientes);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error en la búsqueda: " + ex.Message;
                return View("Index", new List<Cliente>());
            }
        }
    }
}