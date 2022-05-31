using Northwind.DataModels.Shipment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels
{
    public class RegionDto
    {
        [Display(Name ="Region Id")]
        public short RegionId { get; set; }

        [Display(Name = "Region Description*")]
        [Required(ErrorMessage ="Region description cannot be empty")]
        public string RegionDescription { get; set; }
    }
}
