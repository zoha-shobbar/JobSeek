using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class PasswordAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            Regex regexPassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            if (((string)value).Trim().Length < 8 && !regexPassword.IsMatch((string)value))
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Invalid password";
        }
    }
}