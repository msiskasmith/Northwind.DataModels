using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Shipment
{
    public class ShipperDto
    {
        [Display(Name = "Shipper Id")]
        public short ShipperId { get; set; }

        [MaxLength(40, ErrorMessage ="Shipper Name cannot be more than 40 characters.")]
        [MinLength(4, ErrorMessage = "Shipper Name cannot be less than 4 characters.")]
        [Display(Name = "Shipper Name")]
        [Required(ErrorMessage = "Shipper name cannot be empty.")]
        public string ShipperName { get; set; }

        [Phone(ErrorMessage ="Please provide a valid phone number")]
        [Display(Name = "Shipper Phone")]
        public string ShipperPhone { get; set; }
    }
}
