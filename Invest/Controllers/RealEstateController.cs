using Invest.Domain;
using Invest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

        public IActionResult List(string usage)
        {
            return View(dataManager.RealAstates.GetRealEstateByUsge(usage));
        }

        public IActionResult Show(Guid id)
        {

            var astate = dataManager.RealAstates.GetRealEstateItemById(id);

            string addr = astate.Address;// + astate.Floor != null ? "" : "Этаж " + astate.Floor + astate.Number != null ? "" : "Квартира " + astate.Number;

            List<string> exp = astate.Expenses.Split(',').ToList();

            int total = 0;

            for (int i = 0; i < exp.Count; i++)
            {
                total += int.Parse(exp[i].Substring(exp[i].IndexOf(':') + 1, exp[i].Length - exp[i].IndexOf(':') - 1));
            }

            var plan = dataManager.Images.GetPlanImageByAstateId(id);
            var im = dataManager.Images.GetPlanImagesByAstateId(id);
            var ex = astate.Expenses.Split(',').ToList();
            var hp = dataManager.HistoryPrices.GetHistoryPrice(id);
            var hd = dataManager.HistoryPrices.GetHistoryDate(id);
            var mp = dataManager.HistoryPrices.GetHistoryPrice(id).Min() - 100000;
            ShowRealEstateViewModel model = new()
            {
                RealEstate = astate,
                Plan = plan,
                Images = im,
                FullAddress = addr,
                Expenses = ex,
                TotalExpenses = total,
                HistoryPrice = hp,
                HistoryDate = hd,
                MinPrice = mp
            };
            return View(model);
        }
    }
}
