using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations
{
    public class JoinDateValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime _date = Convert.ToDateTime(value);
            if (_date>DateTime.Today && ((DateTime.Now-_date).TotalDays/365)>10)
            {
                return new ValidationResult(" Tarih geçerli değil.");
            }
            else
            {
                return ValidationResult.Success;
            }
            return base.IsValid(value, validationContext);
        }

    }
}
