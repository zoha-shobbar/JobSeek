using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Validations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BirthDayAttribute:ValidationAttribute
    {
        public bool IsValid(object? value)
        {
            if ((DateTime)value > DateTime.Now)
                return true;
            return false;
        }
    }
}
