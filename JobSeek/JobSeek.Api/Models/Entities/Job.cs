using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Job : BaseEntity
    {
        public string Details { get; set; }
        public string PositionTitle { get; set; }
        public enum Status { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public DateTimeOffset ExpireDate { get; set; }
        public enum TypeCooperation { get; set; }
        public enum ContractType { get; set; }
        public enum WorkExperience { get; set; }
        public enum Workplace { get; set; }
        public enum Advantages { get; set; }
        public enum Grade { get; set; }
        public enum SeniorityLevel { get; set; }
        public enum TypeIndustry { get; set; }



        //Relations
        public Employer Employer { get; set; }
        public int EmployerId { get; set; }

        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
