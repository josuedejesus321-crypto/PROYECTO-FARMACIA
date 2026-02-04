// Models/DashboardViewModel.cs
namespace FarmaciaWeb.Models
{
    public class DashboardViewModel
    {
        public int TotalCustomers { get; set; }
        public int TotalMedicine { get; set; }
        public int OutOfStock { get; set; }

        // ¡Esta es la propiedad que falta y causa el error!
        public int TotalSuppliers { get; set; }
    }
}