using Invest.Domain.Entities;
namespace Invest.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<RealEstatesWithImageViewModel> realEstates { get; set; }
        public IEnumerable<RealEstatesWithImageViewModel> estatesCommerce { get; set; }
        public IEnumerable<RealEstatesWithImageViewModel> estatesLiving { get; set; }
        public IEnumerable<RealEstatesWithImageViewModel> estatesLand { get; set; }
    }
}
