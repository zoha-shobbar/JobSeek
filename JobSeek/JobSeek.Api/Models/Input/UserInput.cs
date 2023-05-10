using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Models.Input
{
    public abstract class UserInput
    {
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
