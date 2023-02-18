using Invest.Domain.Entities;
using Invest.Domain.Repositories.Abstract;
using Invest.Models;
using Invest.Service;
using Microsoft.EntityFrameworkCore;
using Type = Invest.Service.Type;

namespace Invest.Domain.Repositories.EntityFramework
{
    public class EFRealStateRepository : IRealAstateRepository
    {
        private readonly AppDbContext context;

        public EFRealStateRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<RealEstatesWithImageViewModel> GetRealEstatesByType(string usage, string type, int count)
        {
            List<RealEstatesWithImageViewModel> list = new List<RealEstatesWithImageViewModel>();
            List<RealEstate> temp;
            if (usage == " ")
            {
                temp = context.RealEstates.OrderByDescending(x => x.DateAdded).Where(x => x.Type == type).Take(count).ToList();
            }
            else temp = context.RealEstates.OrderByDescending(x => x.DateAdded).Where(x => x.Usage == usage && x.Type == type).Take(count).ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                var t = context.Images.Where(x => x.StateId == temp[i].Id).OrderBy(x => x.DateAdded).Skip(1).FirstOrDefault();
                if (t != default)
                    list.Add(new RealEstatesWithImageViewModel { RealEstate = temp[i], Image = context.Images.Where(x => x.StateId == temp[i].Id).OrderBy(x => x.DateAdded).Skip(1).FirstOrDefault() });
            }
            return list;
        }

        public IQueryable<RealEstate> GetRealEstates()
        {
            return context.RealEstates;
        }

        public IQueryable<RealEstate> GetRealEstatesByNameUser(string name)
        {
            return context.RealEstates.Where(x => x.OwnerName == name);
        }

        public RealEstate GetRealEstateItemById(Guid id)
        {
            return context.RealEstates.Where(x => x.Id == id).FirstOrDefault();
        }

        public void SaveRealAstatesItem(RealEstate realEstate)
        {
            if (realEstate.Id == default)
            {
                context.Entry(realEstate).State = EntityState.Added;
            }
            else context.Entry(realEstate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletRealAsteteItem(Guid id)
        {
            context.RealEstates.Remove(context.RealEstates.Where(x => x.Id == id).FirstOrDefault());
            context.SaveChanges();
        }

        public IQueryable<RealEstate> GetRealEstateByUsge(string usage)
        {
            return context.RealEstates.Where(x => x.Usage == usage);


        }
    }
}
