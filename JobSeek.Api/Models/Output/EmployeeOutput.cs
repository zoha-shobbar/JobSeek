using JobSeek.Api.Enums;
using JobSeek.Api.Models.Output;

namespace JobSeek.Api.Models.Output
{
    public class EmployeeOutput : UserOutput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SeniorityLevel SeniorityLevel { get; set; }
        public Education Education { get; set; }
        public Gender Gender { get; set; }
        public MilitaryService MilitaryService { get; set; }
        public MaterialStatus MaritalStatus { get; set; }

    }
}
