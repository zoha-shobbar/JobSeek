using JobSeek.Api.Enums;

namespace JobSeek.Api.Models.Input
{
    public class EmployeeInput:UserInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Education Education { get; set; }
        public SeniorityLevel SeniorityLevel  { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public Gender Gender { get; set; }
        public MaterialStatus MaritalStatus { get; set; }
        public MilitaryService MilitaryService { get; set; }

    }
}
