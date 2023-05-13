using JobSeek.Api.Enums;
using JobSeek.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Models.Input
{
    public class EmployeeInput:UserInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Education MajoringIn { get; set; }
        public SeniorityLevel Degree { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public Gender Gender { get; set; }
        public MaterialStatus MaritalStatus { get; set; }
        public MilitaryService MilitaryService { get; set; }

        [Required(ErrorMessage ="Invalid National Code")]
        [NationalCodeValidate]
        public string NatioanlCode { get; set; }
    }
}
