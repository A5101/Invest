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
                estatesCommerce = dataManager.RealAstates.GetRealEstatesByType(Service.Usage.Commerce, Service.Type.Build, 3),
                estatesLand = dataManager.RealAstates.GetRealEstatesByType(Service.Usage.Commerce, Service.Type.Build, 3),
                estatesLiving = dataManager.RealAstates.GetRealEstatesByType(Service.Usage.None, Service.Type.Land, 3),
                realEstates = dataManager.RealAstates.GetRealEstatesByType(Service.Usage.None, Service.Type.Land, 5)
            };
            return View(model);
        }
    }
}
