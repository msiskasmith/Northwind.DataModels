using Northwind.DataModels.Shipment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Location
{
    public class RegionDto
    {
        [Display(Name = "Region Id")]
        public short RegionId { get; set; }

        [Display(Name = "Region Description")]
        [Required(ErrorMessage = "Region description cannot be empty")]
        [MaxLength(30, ErrorMessage = "Description cannot be more than 30 characters.")]
        [MinLength(4, ErrorMessage = "Description be less than 4 characters.")]
        public string RegionDescription { get; set; }
    }
}
