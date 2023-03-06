using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
    public class EmployeeJoinDateValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                DateTime _date = Convert.ToDateTime(value);
                if (_date > DateTime.Today)
                {
                    return new ValidationResult("Join date cannot be greater than today.");
                }
                else if (((DateTime.Now - _date).TotalDays / 365) > 100)
                {
                    return new ValidationResult("Join date cannot be before 100 years.");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("Employee join date cannot be empty!");
            }
            
            return base.IsValid(value, validationContext);
        }
    }
}
