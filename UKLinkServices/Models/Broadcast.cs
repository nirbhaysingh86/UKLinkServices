using System;
using System.ComponentModel.DataAnnotations;

namespace UKLinkServices.Models
{
    public class Broadcast
    {
        public Details details { get; set; }
        public string Link { get; set; }
    }
    public class Details
    {
        public DateTime? BroadcastDate { get; set; }
        [Required]
        [Range(typeof(bool), "true", "true",
        ErrorMessage = "This form disallows unapproved ships.")]
        public bool Urgent { get; set; }
        public string DeliveryOption { get; set; }
        public string BroadcastReason { get; set; }
        
    }
}
