using Invest.Domain;
using Invest.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Invest.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly DataManager dataManager;

        public FavoriteController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult AddToFavorite(Guid id, string userName)
        {
            if (userName != null)
            {
                RealEstate _event = dataManager.RealAstates.GetRealEstateItemById(id);
                if (_event != null)
                {
                    dataManager.Favorites.SaveFavoriteItem(new Favorite { UserName = userName, StateId = id });
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public IActionResult RemoveFromFavorite(Guid eventId, string userName)
        {
            dataManager.Favorites.DeleteFromFavoriteById(eventId, userName);
            return RedirectToRoute(new { controller = "Favorite", action = "ShowFavorite", name = userName });
        }

        public IActionResult ShowFavorite(string name)
        {
            return View(dataManager.Favorites.GetFavoriteByName(name));
        }
    }
}
