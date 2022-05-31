using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;


namespace Northwind.DataModels.Helpers
{
    sealed public class DateRangeValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dateToValidate = (DateTime)value;
            if (dateToValidate >= DateTime.UtcNow)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "Make sure your date is >= than today");
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture,
              ErrorMessageString, name);
        }

    }
}
