using Microsoft.AspNetCore.Mvc;

namespace Invest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
