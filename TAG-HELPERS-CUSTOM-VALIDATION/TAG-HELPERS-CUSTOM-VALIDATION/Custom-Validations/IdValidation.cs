using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
    public class IdValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                int id = Convert.ToInt32(value);
                if (id<0)
                {
                    return new ValidationResult("Id must be greater than 0");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("Id cannot be null");
            }
            return base.IsValid(value, validationContext);
        }
    }
}
