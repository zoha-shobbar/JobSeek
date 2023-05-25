using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class RegisterIdAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            Regex regexRegisterId = new Regex(@"^[1-9]\d*$");
            if (((string)value).Trim().Length <= 2 && !regexRegisterId.IsMatch((string)value))
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Invalid register id.";
        }
    }
}