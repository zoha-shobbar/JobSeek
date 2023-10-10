using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class PhoneNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            Regex regexPhoneNumber = new Regex(@"^0[0-9]{2,}[0-9]{7,}$");   
            if (!regexPhoneNumber.IsMatch((string)value))
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid phone number.";
        }
    }
}