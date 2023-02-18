using Invest.Domain.Entities;
using Invest.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Invest.Domain.Repositories.EntityFramework
{
    public class EFFavoriteRepository :IFavoriteRepository
    {
        private readonly AppDbContext context;

        public EFFavoriteRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Favorite> GetEventItems()
        {
            return context.Favorites;
        }

        public IQueryable<Favorite> GetEventItemsByName(string name)
        {
            return context.Favorites.Where(x => x.UserName == name);
        }

        public void SaveFavoriteItem(Favorite entity)
        {
            context.Favorites.Add(entity);
            context.SaveChanges();
        }

        public IQueryable<RealEstate> GetFavoriteByName(string name)
        {
            if (context == null) return null;

            return from c in context.Favorites.Where(x => x.UserName == name)
                   join e in context.RealEstates on c.StateId equals e.Id
                   select context.RealEstates.FirstOrDefault(x => x.Id == e.Id);
        }

        public void DeleteFromFavoriteById(Guid stateId, string name)
        {
            context.Favorites.Remove(context.Favorites.FirstOrDefault(x => (x.UserName == name && x.StateId == stateId)));
            context.SaveChanges();
        }


        public void RemoveFavorite(IQueryable<Favorite> entity)
        {
            context.Favorites.RemoveRange(entity);
            context.SaveChanges();
        }
    }
}
