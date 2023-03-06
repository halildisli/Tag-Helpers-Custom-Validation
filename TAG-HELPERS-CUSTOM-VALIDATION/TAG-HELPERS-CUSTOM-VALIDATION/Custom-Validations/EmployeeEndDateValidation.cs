using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
    public class EmployeeEndDateValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                DateTime _date = Convert.ToDateTime(value);
                if (_date > DateTime.Today)
                {
                    return new ValidationResult("End date cannot be greater than today");
                }
                else if (((DateTime.Now - _date).TotalDays / 365) > 30)
                {
                    return new ValidationResult("End date cannot be less than 30 years");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return ValidationResult.Success;
            }
            return base.IsValid(value, validationContext);
        }
    }
}
