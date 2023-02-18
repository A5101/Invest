using System.ComponentModel.DataAnnotations;

namespace Invest.Domain.Entities
{
    public class Favorite
    {
        public Guid ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public Guid StateId { get; set; }
        [Required]
        public bool IsChanged { get; set; }
    }
}
