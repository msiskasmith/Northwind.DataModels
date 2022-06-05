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
        [MaxLength(40, ErrorMessage ="Customer Name cannot be more than 40 characters.")]
        [MinLength(4, ErrorMessage ="Customer Name cannot be less than 4 characters.")]
        [Required(ErrorMessage = "Customer name cannot be empty.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [MaxLength(30, ErrorMessage ="Contact Name cannot be more than 30 characters.")]
        [MinLength(4, ErrorMessage = "Contact Name cannot be less than 4 characters.")]
        [Required(ErrorMessage = "Contact name cannot be empty.")]
        [Display(Name = "Contact Name")]
        public string CustomerContactName { get; set; }

        [MaxLength(30, ErrorMessage ="Contact Title cannot be more than 30 characters.")]
        [MinLength(4, ErrorMessage = "Contact Title cannot be less than 4 characters.")]
        [Display(Name = "Contact Title")]
        [Required(ErrorMessage = "Contact title cannot be empty.")]
        public string CustomerContactTitle { get; set; }

        [Phone(ErrorMessage ="Please provide a valid Fax Number.")]
        [Display(Name = "Fax")]
        public string CustomerFax { get; set; }
        [MaxLength(60, ErrorMessage ="Address cannot be more than 60 characters.")]
        [MinLength(10, ErrorMessage = "Address cannot be less than 4 characters.")]
        [Display(Name = "Address")]
        public string CustomerAddress { get; set; }

        [MaxLength(15,ErrorMessage = "City name cannot be more than 15 characters.")]
        [MinLength(3, ErrorMessage = "City Name cannot be less than 3 characters.")]
        [Display(Name = "City")]
        public string CustomerCity { get; set; }

        [Display(Name = "Region")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a region.")]
        public short RegionId { get; set; }

        [MaxLength(10, ErrorMessage ="Postal Code cannot be more than 10 characters.")]
        [MinLength(4, ErrorMessage = "Postal Code cannot be less than 4 characters.")]
        [Display(Name = "Postal Code")]
        public string CustomerPostalCode { get; set; }

        [MaxLength(15, ErrorMessage ="Country Name cannot be more than 15 characters.")]
        [MinLength(4, ErrorMessage = "Country Name cannot be less than 3 characters.")]
        [Display(Name = "Country")]
        public string CustomerCountry { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage ="Please provide a valid Phone Number.")]
        public string CustomerPhone { get; set; }

        public virtual RegionDto Region { get; set; }
    }
}
