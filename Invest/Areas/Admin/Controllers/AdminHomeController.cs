using Microsoft.AspNetCore.Mvc;

namespace Invest.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
