using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Northwind.DataModels.CustomAttributes;
using Northwind.DataModels.Location;
using Northwind.DataModels.Shipment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Employees
{
    public class EmployeeDto
    {
        [Display(Name = "Employee Id")]
        public short EmployeeId { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Last Name cannot be empty")]
        [Display(Name = "Last Name*")]
        public string EmployeeLastName { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "First Name cannot be empty")]
        [Display(Name = "First Name*")]
        public string EmployeeFirstName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Title")]
        public string EmployeeTitle { get; set; }

        [MaxLength(25)]
        [Display(Name = "Title of Courtesy")]
        public string EmployeeTitleOfCourtesy { get; set; }

        [Required(ErrorMessage ="Birth date cannot be empty")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth*")]
        [MaximumDate(-15 * 365)]
        public DateTime? EmployeeBirthDate { get; set; }

        [Required(ErrorMessage ="Hire date cannot be empty")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Hired*")]
        [MaximumDate(1)]
        public DateTime? EmployeeHireDate { get; set; }

        [MaxLength(4)]
        [Display(Name = "Employee Extension")]
        public string EmployeeExtension { get; set; }

        [Display(Name = "Photo")]
        public byte[] EmployeePhoto { get; set; }

        [Display(Name = "Notes")]
        public string EmployeeNotes { get; set; }

        [Display(Name = "Supervisor")]
        [ValidateNever]
        public short? EmployeeSupervisorId { get; set; }

        [MaxLength(255)]
        [Display(Name = "Photo Path")]
        public string EmployeePhotoPath { get; set; }

        [MaxLength(60)]
        [Display(Name = "Address")]
        public string EmployeeAddress { get; set; }

        [MaxLength(15)]
        [Display(Name = "City")]
        public string EmployeeCity { get; set; }
        [Display(Name = "Region*")]
        [Range(1, short.MaxValue,ErrorMessage = "Please select a region.")]
        public short RegionId { get; set; }

        [MaxLength(10)]
        [Display(Name = "Postal Code")]
        public string EmployeePostalCode { get; set; }

        [MaxLength(15)]
        [Display(Name = "Country")]
        public string EmployeeCountry { get; set; }

        [MaxLength(24)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string EmployeePhone { get; set; }

        [Display(Name = "Full Name")]
        public string EmployeeFullName
        {
            get { return EmployeeFirstName + " " + EmployeeLastName; }
        }

        public virtual RegionDto Region { get; set; }
        public virtual EmployeeDto EmployeeSupervisor { get; set; }
    }
}
