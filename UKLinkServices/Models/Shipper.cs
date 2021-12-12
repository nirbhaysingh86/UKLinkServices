using System;
using System.ComponentModel.DataAnnotations;

namespace UKLinkServices.Models
{
    public class Shipper
    {
        [Required]
        [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).")]
        public string Identifier { get; set; }
        public string Classification { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }
    }
}
