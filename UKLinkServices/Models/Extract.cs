using System;
using System.ComponentModel.DataAnnotations;

namespace UKLinkServices.Models
{
    public class Extract
    {
        [Required]
        public string NetworkType { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Identifier too long (16 character limit).")]
        public string NetworkDesc { get; set; }

         
    }
}
