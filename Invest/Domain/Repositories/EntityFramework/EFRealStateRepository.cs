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

        public IQueryable<RealEstate> GetRealEstatesByType(string usage, string type, int count)
        {
            if (usage == " ") return context.RealEstates.OrderByDescending(x => x.DateAdded).Where(x => x.Type == type).Take(count);
            return context.RealEstates.OrderByDescending(x => x.DateAdded).Where(x => x.Usage == usage && x.Type == type).Take(count);
        }

        public IQueryable<RealEstate> GetRealEstates()
        {
            return context.RealEstates;
        }

        public RealEstate GetRealEstateItemById(Guid id)
        {
            return context.RealEstates.Where(x => x.Id == id).FirstOrDefault();
        }

        public void SaveRealAstatesItem(RealEstate realEstate)
        {
            context.RealEstates.Add(realEstate);
            context.SaveChanges();
        }

        public void DeletRealAsteteItem(Guid id)
        {
            context.RealEstates.Remove(context.RealEstates.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
