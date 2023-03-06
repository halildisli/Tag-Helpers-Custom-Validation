using TAG_HELPERS_CUSTOM_VALIDATION.Custom_Validations;
using System.ComponentModel.DataAnnotations;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Models
{
    public class Employee
    {
        [Display(Name ="Employee Id")]
        [Required(ErrorMessage ="Employee must have Employee ID!")]
        [IdValidation]
        public int? Id { get; set; }
        [Required(ErrorMessage ="Employee must be have First Name")]
        [Display(Name ="First Name")]
        [MinLength(3,ErrorMessage ="First Name must be at least 3 characters.")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Employee must be have Last Name")]
        [Display(Name ="Last Name")]
        [MinLength(3, ErrorMessage = "Last Name must be at least 3 characters.")]
        public string? LastName { get; set; }
        [Display(Name ="E-Mail")]
        [EmailValidation]
        public string? Email { get; set; }
        [AddressValidation]
        public string? Address { get; set; }
        [Display(Name ="Phone Number")]
        [PhoneNumberValidation]
        public string? PhoneNumber { get; set; }
        [Display(Name ="Birth Date")]
        [EmployeeBirthDateValidation]
        public DateTime? BirthDate { get; set; }
        [Display(Name ="Start Date of Job")]
        [EmployeeJoinDateValidation]
        public DateTime? DateOfStart { get; set; }
        [Display(Name ="End Date of Job")]
        [EmployeeEndDateValidation]
        public DateTime? DateOfEnd { get; set; }
        [Required]
        public EmployeeType TypeOfEmployee { get; set; }
    }
    public enum EmployeeType
    {
        Standart=0,
        Manager=1
    }
}
