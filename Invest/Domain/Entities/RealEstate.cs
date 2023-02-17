
using Invest.Service;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
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
        public string? Number { get; set; }//Номер квартиры
        public string? Floor { get; set; }//Этаж
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
        [Required]
        public double Raiting { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public bool Isrepaired { get; set; }
        [Required]
        public string Expenses { get; set; }//Расходы
        [Required]
        public int Income { get; set; }//Доходы
    }
}
