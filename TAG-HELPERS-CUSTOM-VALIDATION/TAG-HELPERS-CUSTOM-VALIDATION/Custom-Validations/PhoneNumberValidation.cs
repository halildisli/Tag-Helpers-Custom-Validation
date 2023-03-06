using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
    public class PhoneNumberValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                string phoneNumber = value.ToString();
                if (phoneNumber.Length != 10)
                {
                    return new ValidationResult("Your phone number must be ten characters.");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("Your phone number cannot be empty.");
            }
            return base.IsValid(value, validationContext);
        }
    }
}
