using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Validations
{
    public class MinSalaryAttribute : ValidationAttribute
    {

        private readonly int _minSalary;

        public MinSalaryAttribute(int minSalary)
        {
            _minSalary = minSalary;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            if (value.GetType() == typeof(int))
            {
                int salary = (int)value;
                if (salary >= _minSalary)
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