using Invest.Domain.Entities;
using Invest.Domain.Repositories.Abstract;
using Invest.Models;
using Invest.Service;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<RealEstatesViewModel> GetRealEstatesByType(string usage, string type, int count)
        {
            List<RealEstatesViewModel> list = new List<RealEstatesViewModel>();
            List<RealEstate> temp;
            if (usage == " ") 
            {
                temp = context.RealEstates.OrderByDescending(x => x.DateAdded).Where(x => x.Type == type).Take(count).ToList(); 
            } else temp = context.RealEstates.OrderByDescending(x => x.DateAdded).Where(x => x.Usage == usage && x.Type == type).Take(count).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                list.Add(new RealEstatesViewModel { RealEstate = temp[i], Image = context.Images.Where(x => x.StateId == temp[i].Id).FirstOrDefault() });
            }
            return list;
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
            if (realEstate.Id == default)
                context.Entry(realEstate).State = EntityState.Added;
            context.Entry(realEstate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletRealAsteteItem(Guid id)
        {
            context.RealEstates.Remove(context.RealEstates.Where(x => x.Id == id).FirstOrDefault());
            context.SaveChanges();
        }
    }
}
