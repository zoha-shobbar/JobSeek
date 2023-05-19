using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class NumberOfCompanyMembersAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            Regex regexNumberOfCompanyMembers = new Regex(@"^\d+$");
            if (((string)value).ToString().Trim().Length < 2 && !regexNumberOfCompanyMembers.IsMatch((string)value))
                return false;
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"the number of company members is invalid";
        }
    }
}