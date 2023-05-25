using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Validations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BirthDateAttribute:ValidationAttribute
    {
        public bool IsValid(object? value)
        {
            if ((DateTime)value > DateTime.Now)
                return false;

            return true;
        }
    }
}
