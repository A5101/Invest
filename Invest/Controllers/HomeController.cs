using Invest.Domain;
using Invest.Models;
using Microsoft.AspNetCore.Mvc;

namespace Invest.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel
            {
                estatesCommerce = dataManager.RealAstates.GetRealEstatesByType("Коммерческое", "Здание", 3),
                estatesLand = dataManager.RealAstates.GetRealEstatesByType(" ", "Участок", 3),
                estatesLiving = dataManager.RealAstates.GetRealEstatesByType("Жилое", "Здание", 3),
                realEstates = dataManager.RealAstates.GetRealEstatesByType(" ", "Участок", 5)
            };
            return View(model);
        }
    }
}
