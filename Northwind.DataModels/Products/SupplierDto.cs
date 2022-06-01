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


        [MaxLength(40)]
        [Required(ErrorMessage = "Supplier name cannot be empty")]
        [Display(Name = "Supplier Name*")]
        public string SupplierName { get; set; }

        [MaxLength(30)]
        [Required(ErrorMessage = "Contact Name cannot be empty")]
        [Display(Name = "Contact Name*")]
        public string SupplierContactName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Contact Title")]
        public string SupplierContactTitle { get; set; }

        [MaxLength(24)]
        [Phone]
        [Display(Name = "Fax")]
        public string SupplierFax { get; set; }
        [MaxLength(60)]

        [Display(Name = "Address")]
        public string SupplierAddress { get; set; }

        [MaxLength(15)]
        [Display(Name = "City")]
        public string SupplierCity { get; set; }

        [Display(Name = "Region*")]
        [Required(ErrorMessage = "Region cannot be empty")]
        public short RegionId { get; set; }

        [MaxLength(10)]
        [Display(Name = "Postal Code")]
        public string SupplierPostalCode { get; set; }

        [MaxLength(15)]
        [Display(Name = "Country")]
        public string SupplierCountry { get; set; }

        [MaxLength(24)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string SupplierPhone { get; set; }

        public virtual RegionDto Region { get; set; }
    }
}
