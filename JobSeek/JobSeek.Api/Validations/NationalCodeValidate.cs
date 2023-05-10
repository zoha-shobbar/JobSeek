using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NationalCodeValidate:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value == null) 
                return true;

            Regex NationalCodeRegex = new Regex(@"^[0-9]{10}$");
            Match NationalCodeMatch = NationalCodeRegex.Match((string)value);
            if (value.ToString().Length != 10 && NationalCodeMatch.Success != true)
                return false;

            return true;
        }
    }
}
