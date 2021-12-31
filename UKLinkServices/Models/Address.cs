using System;
using System.ComponentModel.DataAnnotations;

namespace UKLinkServices.Models
{
    public class Address
    {
        public string HouseNumber { get; set; }
        public string StreetBuildingName { get; set; }
        public string PrincipalStreet { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string ExtractReason { get; set; }
    }
}
