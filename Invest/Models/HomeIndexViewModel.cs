using Invest.Domain.Entities;
namespace Invest.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<RealEstatesViewModel> realEstates { get; set; }
        public IEnumerable<RealEstatesViewModel> estatesCommerce { get; set; }
        public IEnumerable<RealEstatesViewModel> estatesLiving { get; set; }
        public IEnumerable<RealEstatesViewModel> estatesLand { get; set; }
    }
}
