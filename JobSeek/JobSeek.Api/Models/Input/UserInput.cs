using JobSeek.Api.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Models.Input
{
    public abstract class UserInput
    {

        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "invalid Phone number ")]
        [PhoneNumValidate]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(12,ErrorMessage = "invalid Password", MinimumLength =4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
