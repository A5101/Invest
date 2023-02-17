using System.ComponentModel.DataAnnotations;

namespace Invest.Domain.Entities
{
    public class HistoryPrices
    {
        [Required]
        public Guid StateId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
