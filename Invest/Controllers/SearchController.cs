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
            List<string> exp = dataManager.RealAstates.GetRealEstates().Select(x => x.Expenses).ToList();

            int total = 0;

            for (int i = 0; i < exp.Count; i++)
            {
                total += int.Parse(exp[i].Substring(exp[i].IndexOf(':') + 1, exp[i].Length - exp[i].IndexOf(':') - 1));
            }
            dataManager.RealAstates.GetRealEstates().Where(x => x.Income <= model.MaxIncome && x.Income >= model.MinIncome && x.Raiting <= model.MaxRaiting && x.Raiting >= model.MinRaiting && total <= model.MaxExp && total >= model.MinExp);
            return View();
        } 
    }
}
