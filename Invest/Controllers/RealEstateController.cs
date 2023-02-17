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
        public IActionResult Show(Guid id)
        {
            
            var astate = dataManager.RealAstates.GetRealEstateItemById(id);

            string addr = astate.Address + astate.Floor == "Пусто" ? "" : "Этаж "  + astate.Floor + astate.Number == "Пусто" ? "" : "Квартира "+astate.Number;

            List<string> exp = astate.Expenses.Split(',').ToList();

            int total = 0;

            for (int i = 0; i < exp.Count; i++)
            {
                 total += int.Parse(exp[i][exp[i].IndexOf(':')..]);
            }

            ShowRealAstateViewModel model = new()
            {
                RealEstate = astate,
                Plan = dataManager.Images.GetPlanImageByAstateId(id),
                Images = dataManager.Images.GetPlanImagesByAstateId(id),
                FullAddress = addr,
                Expenses = astate.Expenses.Split(',').ToList(),
                TotalExpenses = total,
                HistoryPrice = dataManager.HistoryPrices.GetHistoryPrice(id),
                HistoryDate = dataManager.HistoryPrices.GetHistoryDate(id),
                MinPrice = dataManager.HistoryPrices.GetHistoryPrice(id).Min() - 100000
            };
            return View(model);
        }
    }
}
