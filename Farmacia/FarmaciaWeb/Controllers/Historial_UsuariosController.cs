using Microsoft.AspNetCore.Mvc;
using LogicaCompartida.Entidades;
using LogicaCompartida.DataAccess;
// Quitar: using static LogicaCompartida.Entidades.Definir_Historial_Usuario;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic; // Asegurar que System.Collections.Generic esté disponible
using SelectPdf;

namespace FarmaciaWeb.Controllers
{
    // Cambié el nombre del Controller a Historial_UsuariosController para ser consistente
    // con la práctica común de MVC, aunque el singular funcionará si la carpeta de vista coincide.
    public class Historial_UsuarioController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var Historial_Usuario = Consultas_Historial_Usuarios.ObtenerTodoElHistorialUsuarios();
                return View(Historial_Usuario);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar los clientes: " + ex.Message;
                // ✅ CORRECCIÓN 1: Devolver la Entidad COMPLETA, no el DAL.
                return View(new List<LogicaCompartida.Entidades.Definir_Historial_Usuario>());
            }
        }

        // Usar [HttpGet] es más común para filtros de búsqueda.
        [HttpGet]
        public IActionResult Search(string searchTerm)
        {
            try
            {
                // Definir la lista con la Entidad completa
                List<LogicaCompartida.Entidades.Definir_Historial_Usuario> Historialusuarios;

                // Usar IsNullOrWhiteSpace es más robusto para verificar si hay texto
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    Historialusuarios = Consultas_Historial_Usuarios.ObtenerTodoElHistorialUsuarios();
                }
                else
                {
                    // Si el usuario escribe texto, buscar por Nombre de Usuario (string)
                    // Asumiendo que BuscarUsuariosPorNombreUsuario recibe un string.
                    Historialusuarios = Consultas_Historial_Usuarios.BuscarUsuariosPorNombreUsuario(searchTerm);
                }

                ViewBag.SearchTerm = searchTerm;
                return View("Index", Historialusuarios);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error en la búsqueda: " + ex.Message;
                // ✅ CORRECCIÓN 2: Devolver la Entidad COMPLETA, no el DAL.
                return View("Index", new List<LogicaCompartida.Entidades.Definir_Historial_Usuario>());
            }
        }
    }
}