using Invest.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Invest.Controllers
{
    public class RealEstateController : Controller
    {
        private readonly DataManager dataManager;

        public RealEstateController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
