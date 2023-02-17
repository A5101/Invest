using Invest.Areas.Admin.Controllers;
using Invest.Domain;
using Invest.Domain.Entities;
using Invest.Service;
using Invest.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Invest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RealEstatesItems : Controller
    {
        private readonly DataManager dataManager;

        private readonly IWebHostEnvironment hostingEnvironment;

        public RealEstatesItems(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
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
                return base.RedirectToAction(nameof(Invest.Controllers.HomeController.Index), nameof(Invest.Controllers.HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.RealAstates.DeletRealAsteteItem(id);
            return base.RedirectToAction(nameof(Invest.Controllers.HomeController.Index), nameof(Invest.Controllers.HomeController).CutController());
        }

    }
}