using Invest.Domain;
using Invest.Models;
using Microsoft.AspNetCore.Mvc;

namespace Invest.Controllers
{
    public class SearchController:Controller
    {
        private readonly DataManager dataManager;

        public SearchController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Search(FilterViewModel model)
        {
            if (model.MaxCost == 0)
            {
                return View();
            }
            else
            {

                return View(new FilterViewModel { Estate = dataManager.RealAstates.GetRealEstates().Where(x => x.Income <= model.MaxIncome && x.Income >= model.MinIncome).ToList() });
            }
        }

    }
}
