using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class MaxSalaryAttribute : ValidationAttribute
    {
        private readonly int _maxSalary;

        public MaxSalaryAttribute(int maxSalary)
        {
            _maxSalary = maxSalary;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            if (value.GetType() == typeof(int))
            {
                int salary = (int)value;
                if (salary <= _maxSalary)
                {
                    return true;
                }
            }

            return false;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid value";
        }
    }
}