using Northwind.DataModels.Location;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Products
{
    public class SupplierDto
    {
        [Display(Name = "Supplier Id")]
        public short SupplierId { get; set; }

        [Display(Name = "Home Page")]
        public string SupplierHomepage { get; set; }


        [MaxLength(40, ErrorMessage ="Supplier Name cannot be more than 40 characters.")]
        [MinLength(4, ErrorMessage = "Supplier Name cannot be less than 4 characters.")]
        [Required(ErrorMessage = "Supplier name cannot be empty")]
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [MaxLength(30, ErrorMessage ="Contact Name cannot be more than 30 characters.")]
        [MinLength(4, ErrorMessage = "Contact Name cannot be less than 4 characters.")]
        [Required(ErrorMessage = "Contact Name cannot be empty")]
        [Display(Name = "Contact Name")]
        public string SupplierContactName { get; set; }

        [MaxLength(30, ErrorMessage ="Contact Title cannot be more than 30 characters.")]
        [MinLength(4, ErrorMessage = "Contact Title cannot be less than 4 characters.")]
        [Display(Name = "Contact Title")]
        public string SupplierContactTitle { get; set; }

        [Phone(ErrorMessage ="Please provide a valid Fax Number")]
        [Display(Name = "Fax")]
        public string SupplierFax { get; set; }

        [MaxLength(60, ErrorMessage ="Address cannot be more than 60 characters.")]
        [MinLength(4, ErrorMessage = "Address cannot be less than 4 characters.")]
        [Display(Name = "Address")]
        public string SupplierAddress { get; set; }

        [MaxLength(15, ErrorMessage ="City cannot be more than 15 characters.")]
        [MinLength(3, ErrorMessage = "City cannot be less than 2 characters.")]
        [Display(Name = "City")]
        public string SupplierCity { get; set; }

        [Display(Name = "Region")]
        [Required(ErrorMessage = "Region cannot be empty")]
        public short RegionId { get; set; }

        [MaxLength(10, ErrorMessage ="Postal Code cannot be more than 10 characters.")]
        [MinLength(4, ErrorMessage = "Postal Code cannot be less than 4 characters.")]
        [Display(Name = "Postal Code")]
        public string SupplierPostalCode { get; set; }

        [MaxLength(15, ErrorMessage ="Country cannot be more than 15 characters.")]
        [MinLength(4, ErrorMessage = "Country cannot be less than 4 characters.")]
        [Display(Name = "Country")]
        public string SupplierCountry { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage ="Please provide a valid Phone Number")]
        public string SupplierPhone { get; set; }

        public virtual RegionDto Region { get; set; }
    }
}
