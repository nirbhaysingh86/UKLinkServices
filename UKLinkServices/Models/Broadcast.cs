using System;
using System.ComponentModel.DataAnnotations;

namespace UKLinkServices.Models
{
    public class Broadcast
    {
        [Required]
        public string DmspType { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Identifier too long (16 character limit).")]
        public string DmspkDesc { get; set; }

         
    }
}
