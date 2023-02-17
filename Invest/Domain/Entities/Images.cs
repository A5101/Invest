using System.ComponentModel.DataAnnotations;

namespace Invest.Domain.Entities
{
    public class Images
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public Guid StateId { get; set; }

    }
}
