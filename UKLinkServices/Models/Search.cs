using System;
using System.ComponentModel.DataAnnotations;

namespace UKLinkServices.Models
{
    public class Search
    {
        [Required]
        public string SearchType { get; set; }
         
        public Address Address { get; set; }
        public Mprn Mprn { get; set; }

    }
}
