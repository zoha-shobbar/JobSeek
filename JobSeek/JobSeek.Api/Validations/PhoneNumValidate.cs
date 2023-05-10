using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PhoneNumValidate: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) 
                return true;
            Regex PhoneNumRegex = new Regex(@"^((\+98|0)9\d{9})$");
            Match PhoneMatch = PhoneNumRegex.Match((string)value);
            if ((string)value != null && PhoneMatch.Success != true)
                return false;

            return true;

        }
    }
}
