using Northwind.DataModels.CustomAttributes;
using Northwind.DataModels.Employees;
using Northwind.DataModels.Location;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Shipment
{
    public class OrderDto
    {
        [Display(Name = "Order Id")]
        public short OrderId { get; set; }

        [Display(Name = "Customer")]
        [Required(ErrorMessage = "Please select a customer")]
        public string CustomerId { get; set; }

        [Display(Name = "Assigned to")]
        [Required(ErrorMessage = "Please select the assigned employee.")]
        public string EmployeeId { get; set; }

        [Required(ErrorMessage = "Order date cannot be empty")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Order Date")]
        [MaximumDate(0)]
        public DateTime? OrderDate { get; set; }

        [Required(ErrorMessage = "Required date cannot be empty")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Required Date*")]
        [MinimumDate(0)]
        public DateTime? OrderRequiredDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Shipped Date")]
        public DateTime? OrderShippedDate { get; set; }

        [Display(Name = "Shipper")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a shipper.")]
        public short? ShipperId { get; set; }

        [Display(Name = "Freight")]
        public float? OrderFreight { get; set; }

        [MaxLength(40, ErrorMessage ="The Ship Name cannot be more than 40 characters.")]
        [MinLength(4, ErrorMessage ="The Ship Name cannot be less than 4 characters.")]
        [Display(Name = "Ship Name")]
        public string OrderShipName { get; set; }

        [MaxLength(40, ErrorMessage = "The Ship Address cannot be more than 40 characters")]
        [Display(Name = "Ship Address")]
        public string OrderShipAddress { get; set; }

        [MaxLength(15, ErrorMessage = "The Ship City cannot be more than 15 characters")]
        [MinLength(4, ErrorMessage = "The Ship Address cannot be less than 4 characters.")]
        [Display(Name = "Ship City")]
        public string OrderShipCity { get; set; }

        [Display(Name = "Ship Region")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a ship region.")]
        public short ShipRegionId { get; set; }

        [MaxLength(10, ErrorMessage = "Postal code cannot be more than 40 characters")]
        [MinLength(4, ErrorMessage = "Postal Code cannot be less than 4 characters.")]
        [Display(Name = "Ship Postal Code")]
        public string OrderShipPostalCode { get; set; }

        [MaxLength(15, ErrorMessage = "The Ship Country cannot be more than 40 characters")]
        [MinLength(4, ErrorMessage = "The Ship Country cannot be less than 4 characters.")]
        [Display(Name = "Ship Country")]
        public string OrderShipCountry { get; set; }

        public virtual CustomerDto Customer { get; set; }
        public virtual EmployeeDto Employee { get; set; }
        public virtual RegionDto ShipRegion { get; set; }
        public virtual ShipperDto Shipper { get; set; }
    }
}
