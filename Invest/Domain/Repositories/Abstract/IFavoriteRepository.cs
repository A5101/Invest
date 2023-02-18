using Invest.Domain.Entities;

namespace Invest.Domain.Repositories.Abstract
{
    public interface IFavoriteRepository
    {
        public IQueryable<Favorite> GetEventItems();
        public IQueryable<Favorite> GetEventItemsByName(string name);

        public void SaveFavoriteItem(Favorite entity);

        public IQueryable<RealEstate> GetFavoriteByName(string name);

        public void DeleteFromFavoriteById(Guid stateId, string name);

        public void RemoveFavorite(IQueryable<Favorite> entity);
    }
}
