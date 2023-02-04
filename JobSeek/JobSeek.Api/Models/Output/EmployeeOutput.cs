using JobSeek.Api.Enums;
using JobSeek.Api.Models.Output;

namespace JobSeek.Api.Models.Input
{
    public class EmployeeOutput : output
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SeniorityLevel MajoringIn { get; set; }
        public Education Degree { get; set; }
        public Gender Gender { get; set; }
        public MilitaryService MilitaryService { get; set; }

    }
}
