using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class SiteAddressAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            Regex regexSiteAddress = new Regex(@"^(http(s)?://)?([\w-]+\.)+[\w-]+(/[\w- ;,./?%&=]*)?$");
            if (!regexSiteAddress.IsMatch((string)value))
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid website address.";
        }
    }
}