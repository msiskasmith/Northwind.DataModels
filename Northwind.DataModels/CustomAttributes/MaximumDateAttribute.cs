using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.CustomAttributes
{
    public class MaximumDateAttribute : ValidationAttribute
    {
        private long _numberOfDaysFromToday { get; set; }
        public MaximumDateAttribute(long numberOfDaysFromToday)
        {
            _numberOfDaysFromToday = numberOfDaysFromToday;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is not null)
            {
                var maximumDate = DateTime.UtcNow.AddDays(_numberOfDaysFromToday);

                if ((DateTime)value <= maximumDate)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult(
                $"{validationContext.DisplayName} cannot be after {maximumDate.ToString("dd MMMM yyyy")}.");
            }

            // If the date is null, return success as it is up to the required attribute to ensure 
            // It is not null

            return ValidationResult.Success;
        }
    }
}
