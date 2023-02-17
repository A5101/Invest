using Invest.Domain.Entities;
namespace Invest.Models
{
    public class HomeIndexViewModel
    {
        public IQueryable<RealEstate> realEstates { get; set; }
        public IQueryable<RealEstate> estatesCommerce { get; set; }
        public IQueryable<RealEstate> estatesLiving { get; set; }
        public IQueryable<RealEstate> estatesLand { get; set; }
    }
}
