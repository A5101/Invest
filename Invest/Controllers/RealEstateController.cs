using Invest.Domain;
using Invest.Domain.Entities;
using Invest.Models;
using Invest.Service;
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
            double R = 0;
            
            double T = 0;
            var astate = dataManager.RealAstates.GetRealEstateItemById(id);
            astate.Risks = 0;
            astate.Liquid = 0.5;

            string addr = astate.Address;
            if (astate.Floor != "") 
            { 
                addr += "Этаж " + astate.Floor;
                int i = int.Parse(astate.Floor);
                if (i == 1) R -= 0.1;
                else if (i < 4) R -= 0.05;
            }
            R += 0.5 * astate.NearPlaces;
            if (astate.Usage == "Коммерческое") R += 0.25;
            if (astate.NearWorsth)R -= 5;
            T = astate.Cost * astate.Area * R;
            if (!astate.AreReady)
            {
                float proc = (float)(100 * T / astate.CostCadastr);
                if (astate.Usage == "Жилое")
                {
                    if (proc < 0.06) astate.Risks += (float)0.5;
                    else if (proc < 0.08) astate.Risks += 1;
                    else if (proc < 0.12) astate.Risks += 2;
                    else astate.Risks += 3;
                } else
                {
                    if (proc < 0.16) astate.Risks += (float)0.5;
                    else if (proc < 0.2) astate.Risks += 1;
                    else if (proc < 0.4) astate.Risks += 2;
                    else astate.Risks += 3;
                }
            }
            astate.Liquid += astate.NearPlaces * 0.02;
            if (int.Parse(astate.Floor) > 16) astate.Liquid -= 0.3;
            else if (int.Parse(astate.Floor) > 5) astate.Liquid += 0.05;
            else astate.Liquid -= 0.15;
            if (astate.NearWorsth) astate.Liquid -= 0.1;

            if (astate.Isrepaired) astate.Liquid += 0.1; else astate.Liquid -= 0.1;

            if (astate.AreReady)
            {
                if (astate.Liquid < 0.2) astate.Risks += (float)1.5;
                else if (astate.Liquid < 0.4) astate.Risks += 1;
            }

            List<string> exp = astate.Expenses.Split(',').ToList();
            double total = 0;

            for (int i = 0; i < exp.Count; i++)
            {
                total += int.Parse(exp[i].Substring(exp[i].IndexOf(':') + 1, exp[i].Length - exp[i].IndexOf(':') - 1));
            }

            if (astate.Usage == "Жилое")
                total += astate.CostCadastr * 0.003 / astate.Liquid;
            else
                total += astate.CostCadastr * 0.02 / astate.Liquid;


            astate.Raiting = astate.Cost * astate.Area * 5 / astate.Liquid / (total + astate.Cost * astate.Area);

            if (astate.Number != "") addr +="Квартира " + astate.Number;

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

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new RealEstate() : dataManager.RealAstates.GetRealEstateItemById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(RealEstate model)
        {
            if (ModelState.IsValid)
            {
                dataManager.RealAstates.SaveRealAstatesItem(model);
                dataManager.HistoryPrices.AddHistory(model.Id, (int)model.Area * model.Cost, DateTime.UtcNow);
                return base.RedirectToAction(nameof(Invest.Controllers.HomeController.Index), nameof(Invest.Controllers.HomeController).CutController());
            }
            return View(model);
        }

        public IActionResult AddImages(Guid id, IFormFileCollection coll)
        {
            foreach (var item in coll)
            {
                byte[] imageData;
                using (var binaryReader = new BinaryReader(item.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)item.Length);
                }
                var im = new Image() { Id = Guid.NewGuid(), StateId = id, _Image = imageData };
                dataManager.Images.AddImage(im);

            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.RealAstates.DeletRealAsteteItem(id);
            return base.RedirectToAction(nameof(Invest.Controllers.HomeController.Index), nameof(Invest.Controllers.HomeController).CutController());
        }
    }
}
