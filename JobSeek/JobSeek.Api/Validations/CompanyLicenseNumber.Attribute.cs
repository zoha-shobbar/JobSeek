using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class CompanyLicenseNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            Regex regexCompanylicenseNumber = new Regex(@"^(\d{2})(\d{3})(\d{7})$");
            if (!regexCompanylicenseNumber.IsMatch((string)value))
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid company license number";
        }
    }
}