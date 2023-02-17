using Invest.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Invest.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly DataManager dataManager;

        public FavoriteController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
