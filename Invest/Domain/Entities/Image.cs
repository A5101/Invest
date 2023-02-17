﻿using System.ComponentModel.DataAnnotations;

namespace Invest.Domain.Entities
{
    public class Image
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public byte[] _Image { get; set; }
        [Required]
        public Guid StateId { get; set; }

    }
}
