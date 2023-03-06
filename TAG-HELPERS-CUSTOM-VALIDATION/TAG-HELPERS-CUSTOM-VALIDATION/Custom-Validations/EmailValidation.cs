using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
    public class EmailValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                string email = value.ToString();
                Regex regex = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
                if (regex.IsMatch(email))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("This email address is invalid.");
                }
            }
            else
            {
                return new ValidationResult("Email address cannot be empty.");
            }
            return base.IsValid(value, validationContext);
        }
    }
}
