using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SelectPdf;

// 1. Usings necesarios para tus capas de lógica y modelos
using FarmaciaWeb.Models;          // Contiene DashboardViewModel
using LogicaCompartida.Services;  // Contiene DashBoardBLL
using LogicaCompartida.Entidades; // Contiene DashboardInfo

namespace FarmaciaWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DashBoardBLL _dashboardBLL; // Declaración de la capa BLL

    // Constructor: Recibe la dependencia DashBoardBLL (Inyección de Dependencias)
    public HomeController(ILogger<HomeController> logger, DashBoardBLL dashboardBLL)
    {
        _logger = logger;
        _dashboardBLL = dashboardBLL;
    }

    public IActionResult Index()
    {
        // 1. Obtener la entidad con los datos reales, consultados desde la DB
        // Esto llama a tu lógica de negocio (BLL)
        DashBoardInfo entity = _dashboardBLL.ObtenerInformacionDashBoard();

        // 2. Mapear la Entidad (DashboardInfo) a un ViewModel (DashboardViewModel)
        // El ViewModel es lo que la vista Razor espera.
        DashboardViewModel dashboardData = new DashboardViewModel
        {
            // Mapeo directo de Entidad (source) a ViewModel (target)
            TotalCustomers = entity.CantidadClientes,
            TotalMedicine = entity.CantidadMedicamentos,
            OutOfStock = entity.CantidadFueraDeStock,
            TotalSuppliers = entity.CantidadProveedores // Para la tarjeta de Proveedores
        };

        // 3. Pasar el ViewModel con los datos a la vista
        return View(dashboardData);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}