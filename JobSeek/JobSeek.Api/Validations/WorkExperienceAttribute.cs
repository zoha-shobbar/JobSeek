using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Validations
{
    public class WorkExperienceAttribute : ValidationAttribute
    {

        private readonly decimal _minValue;
        private readonly decimal _maxValue;

        public WorkExperienceAttribute(decimal minValue, decimal maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true; 
            
            var workExperience = (decimal)value;

            if (workExperience < _minValue || workExperience > _maxValue)
            {
                return false;
            }
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Please enter a valid value";
        }
    }
}