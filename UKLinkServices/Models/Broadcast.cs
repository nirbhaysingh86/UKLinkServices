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
    public class UploadedFile
    {
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
    }
    public class FileViewModel
    {
        /// helpful in combination with @key to make list rendering more efficient
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String ContentType { get; set; }
        public Int64 Size { get; set; }
        public Byte[] Content { get; set; }
        public String ImageDataUrl { get; set; }

        public FileViewModel()
        {
            Id = Guid.NewGuid();
        }

    }
}
