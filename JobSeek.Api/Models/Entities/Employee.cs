using JobSeek.Api.Enums;

namespace JobSeek.Api.Models.Entities
{
    public class Employee : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SeniorityLevel SeniorityLevel { get; set; }
        public Education Education { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public MilitaryService MilitaryService { get; set; }
        public string NatioanlCode { get; set; }
        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
