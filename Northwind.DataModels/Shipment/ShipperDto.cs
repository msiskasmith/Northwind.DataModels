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

        [MaxLength(40)]
        [Display(Name = "Shipper Name*")]
        [Required(ErrorMessage = "Shipper name cannot be empty.")]
        public string ShipperName { get; set; }

        [MaxLength(24)]
        [Phone]
        [Display(Name = "Shipper Phone")]
        public string ShipperPhone { get; set; }
    }
}
