using Invest.Domain.Entities;
using Invest.Domain.Repositories.Abstract;
using Invest.Service;
using Type = Invest.Service.Type;

namespace Invest.Domain.Repositories.EntityFramework
{
    public class EFRealStateRepository:IRealAstateRepository
    {
        private readonly AppDbContext context;

        public EFRealStateRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<RealEstate> GetRealEstatesByType(Usage usage, Type type, int count)
        {
            if (usage == Usage.None) return context.RealEstates.OrderByDescending(x => x.DateAdded).Where(x => x.Type == type).Take(count);
            return context.RealEstates.OrderByDescending(x => x.DateAdded).Where(x => x.Usage == usage && x.Type == type).Take(count);
        }
    }
}
