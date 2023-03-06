using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
    public class AddressValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                string address = value.ToString();
                if (address.Length < 20)
                {
                    return new ValidationResult("Your address must be least 20 characters");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("Your address cannot be empty");
            }
            
            return base.IsValid(value, validationContext);
        }
    }
}
