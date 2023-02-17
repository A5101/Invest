using System.ComponentModel.DataAnnotations;

namespace Invest.Domain.Entities
{
    public class Favorite
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid StateId { get; set; }
        [Required]
        public bool IsChanged { get; set; }
    }
}
