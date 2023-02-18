using Microsoft.EntityFrameworkCore.Diagnostics;
using Invest.Domain.Entities;

namespace Invest.Models
{
    public class FilterViewModel
    {
        public List<RealEstate> Estate { get; set; }
        public int MinCost { get; set; }
        public int MaxCost { get; set; }
        public int MinArea { get; set; }
        public int MaxArea { get; set; }
        public int MinIncome { get; set; }
        public int MaxIncome { get; set; }
        //public int MinExp { get; set; }
        //public int MaxExp { get; set; }
        //public double MinRaiting { get; set; }
        //public double MaxRaiting { get; set; }
        //public double MinPaybackPeriod { get; set; }
        //public double MaxPaybackPeriod { get; set; }
        //public string Type { get; set; }
    }
}
