using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
    public class EmployeeBirthDateValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                DateTime _date = Convert.ToDateTime(value);
                if (((DateTime.Today - _date).TotalDays / 365) < 18)
                {
                    return new ValidationResult("Employee age must be greater 18 years.");
                }
                else if (((DateTime.Today - _date).TotalDays / 365) > 120)
                {
                    return new ValidationResult("Employee age must be least 120 years.");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("Employee birth date cannot be empty. ");
            }
            
            return base.IsValid(value, validationContext);
        }
    }
}
