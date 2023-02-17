using Invest.Domain.Entities;
using Invest.Service;
using Type = Invest.Service.Type;

namespace Invest.Domain.Repositories.Abstract
{
    public interface IRealAstateRepository
    {
        public IQueryable<RealEstate> GetRealEstatesByType(Usage usage, Type type, int count);
    }
}
