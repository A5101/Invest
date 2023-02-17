using System.ComponentModel.DataAnnotations;

namespace Invest.Domain.Entities
{
    public class RealEstate
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string? Address { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public double Area { get; set; }
        [Required]
        public string Usage { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool AreReady { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int NearPlaces { get; set; }
        [Required]
        public bool NearWorsth { get; set; }

    }
}
