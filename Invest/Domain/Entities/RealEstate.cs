
using Invest.Service;
using System.ComponentModel.DataAnnotations;
using Type = Invest.Service.Type;

namespace Invest.Domain.Entities
{
    public class RealEstate
    {
        public RealEstate() => DateAdded = DateTime.UtcNow;
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
        public Usage Usage { get; set; }
        [Required]
        public Type Type { get; set; }
        [Required]
        public bool AreReady { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int NearPlaces { get; set; }
        [Required]
        public bool NearWorsth { get; set; }
        [Required]
        public double Raiting { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
    }
}
