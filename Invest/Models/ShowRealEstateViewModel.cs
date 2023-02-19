using Invest.Domain.Entities;
namespace Invest.Models
{
    public class ShowRealEstateViewModel
    {
        public RealEstate RealEstate { get; set; }
        public byte[] Plan { get; set; }
        public List<byte[]> Images { get; set; }
        public List<string> Expenses { get; set; }
        public double TotalExpenses { get; set; }
        public string FullAddress { get; set; }
        public double[] HistoryPrice { get; set; }
        public string[] HistoryDate { get; set; }
        public double[] HistoryProfit { get; set; }
        public double MinPrice { get; set; }
        public int PaybackPeriod { get; set; }
    }
}