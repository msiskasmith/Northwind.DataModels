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
        public string EmployeeId { get; set; }

        [MaxLength(20, ErrorMessage ="Last Name cannot be more than 20 characters.")]
        [MinLength(2, ErrorMessage ="Last Name cannot be less than 2 characters.")]
        [Required(ErrorMessage = "Last Name cannot be empty.")]
        [Display(Name = "Last Name")]
        public string EmployeeLastName { get; set; }

        [MaxLength(10, ErrorMessage ="First Name cannot be more than 10 characters.")]
        [MinLength(2, ErrorMessage = "First Name cannot be less than 2 characters.")]
        [Required(ErrorMessage = "First Name cannot be empty.")]
        [Display(Name = "First Name")]
        public string EmployeeFirstName { get; set; }

        [MaxLength(256, ErrorMessage = "Email Address cannot be more than 256 characters.")]
        [MinLength(5, ErrorMessage = "Email Address cannot be less than 5 characters.")]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage ="Email Address cannot be empty.")]
        [EmailAddress(ErrorMessage ="Please provide valid email address.")]
        public string EmployeeEmail { get; set; }

        [MaxLength(30, ErrorMessage ="Title cannot be more than 30 characters.")]
        [MinLength(5, ErrorMessage = "Title cannot be less than 5 characters.")]
        [Display(Name = "Title")]
        public string EmployeeTitle { get; set; }

        [MaxLength(25, ErrorMessage ="Title of courtesy cannot be more than 25 characters.")]
        [MinLength(5, ErrorMessage = "Title of courtesy cannot be less than 5 characters.")]
        [Display(Name = "Title of Courtesy")]
        public string EmployeeTitleOfCourtesy { get; set; }

        [Required(ErrorMessage ="Date of Birth cannot be empty.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        [MaximumDate(-15 * 365)]
        public DateTime? EmployeeBirthDate { get; set; }

        [Required(ErrorMessage ="Hire date cannot be empty.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Hired")]
        [MaximumDate(1)]
        public DateTime? EmployeeHireDate { get; set; }

        [MaxLength(4, ErrorMessage ="Extension cannot be more than 4 characters.")]
        [MinLength(2, ErrorMessage = "Extension cannot be less than 2 characters.")]
        [Display(Name = "Employee Extension")]
        public string EmployeeExtension { get; set; }

        [Display(Name = "Photo")]
        public byte[] EmployeePhoto { get; set; }

        [Display(Name = "Notes")]
        [MaxLength(500, ErrorMessage ="Notes cannot be more than 500 characters long.")]
        [MinLength(20, ErrorMessage = "Notes cannot be less than 20 characters.")]
        public string EmployeeNotes { get; set; }

        [Display(Name = "Supervisor")]
        public string EmployeeSupervisorId { get; set; }

        [MaxLength(255, ErrorMessage ="Photo path cannot be more than 255 characters.")]
        [MinLength(10, ErrorMessage = "Phot path cannot be less than 10 characters.")]
        [Display(Name = "Photo Path")]
        public string EmployeePhotoPath { get; set; }

        [MaxLength(60, ErrorMessage ="Address cannot be more than 60 characters.")]
        [MinLength(4, ErrorMessage = "Address cannot be less than 4 characters.")]
        [Display(Name = "Address")]
        public string EmployeeAddress { get; set; }

        [MaxLength(15, ErrorMessage ="City cannot be more than 15 characters.")]
        [Display(Name = "City")]
        public string EmployeeCity { get; set; }
        [Display(Name = "Region")]
        [Range(1, short.MaxValue,ErrorMessage = "Please select a region.")]
        public short RegionId { get; set; }

        [MaxLength(10, ErrorMessage ="Postal Code cannot be more than 10 characters.")]
        [MinLength(4, ErrorMessage = "Postal Code cannot be less than 4 characters.")]
        [Display(Name = "Postal Code")]
        public string EmployeePostalCode { get; set; }

        [MaxLength(15, ErrorMessage ="Country cannot be more than 15 characters.")]
        [MinLength(4, ErrorMessage = "Country cannot be less than 4 characters.")]
        [Display(Name = "Country")]
        public string EmployeeCountry { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage ="Please provide a valid phone number")]
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
