﻿using Invest.Domain.Entities;
namespace Invest.Models
{
    public class ShowRealAstateViewModel
    {
        public RealEstate RealEstate { get; set; }
        public byte[] Plan { get; set; }
        public List<byte[]> Images { get; set; }
        public List<string> Expenses { get; set; }
        public int TotalExpenses { get; set; }
        public string FullAddress { get; set; }
        public int[] HistoryPrice { get; set; }
        public string[] HistoryDate { get; set; }
        public int MinPrice { get; set; }
        public int PaybackPeriod { get; set; }
    }
}