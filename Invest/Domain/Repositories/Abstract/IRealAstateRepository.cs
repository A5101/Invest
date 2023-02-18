using Invest.Domain.Entities;
using Invest.Models;
using Invest.Service;
using Type = Invest.Service.Type;

namespace Invest.Domain.Repositories.Abstract
{
    public interface IRealAstateRepository
    {
        public IEnumerable<RealEstatesViewModel> GetRealEstatesByType(string usage, string type, int count);
        public IQueryable<RealEstate> GetRealEstates();
        public RealEstate GetRealEstateItemById(Guid id);
        public void SaveRealAstatesItem(RealEstate realEstate);
        public void DeletRealAsteteItem(Guid id);
    }
}
