using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Validations
{
    public class ExpireDateAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            DateTime date;

            if (DateTime.TryParse((string)value, out date))
            {
                return date > DateTime.Now;
            }
            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid date";
        }
    }
}
