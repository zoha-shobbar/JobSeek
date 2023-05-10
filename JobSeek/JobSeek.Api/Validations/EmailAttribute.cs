using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class EmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            Regex regexEmail = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            if (!regexEmail.IsMatch((string)value))
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"The email address entered is not valid.";
        }
    }
}