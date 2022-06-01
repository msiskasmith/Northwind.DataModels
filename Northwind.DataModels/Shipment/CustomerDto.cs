using Northwind.DataModels.Location;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Shipment
{
    public class CustomerDto
    {
        [Display(Name = "Customer Id")]
        public string CustomerId { get; set; }
        [MaxLength(40)]
        [Required(ErrorMessage = "Customer name cannot be empty")]
        [Display(Name = "Customer Name*")]
        public string CustomerName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Contact Name")]
        public string CustomerContactName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Contact Title")]
        public string CustomerContactTitle { get; set; }

        [MaxLength(24)]
        [Phone]
        [Display(Name = "Fax")]
        public string CustomerFax { get; set; }
        [MaxLength(60)]
        [Display(Name = "Address")]
        public string CustomerAddress { get; set; }

        [MaxLength(15)]
        [Display(Name = "City")]
        public string CustomerCity { get; set; }

        [Display(Name = "Region*")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a region.")]
        public short RegionId { get; set; }

        [MaxLength(10)]
        [Display(Name = "Postal Code")]
        public string CustomerPostalCode { get; set; }

        [MaxLength(15)]
        [Display(Name = "Country")]
        public string CustomerCountry { get; set; }

        [MaxLength(24)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string CustomerPhone { get; set; }

        public virtual RegionDto Region { get; set; }
    }
}
