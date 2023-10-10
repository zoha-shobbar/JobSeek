using JobSeek.Api.Enums;
using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Job : BaseEntity
    {
        public string Details { get; set; }
        public string PositionTitle { get; set; }
        public JobStatus JobStatus { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public DateTimeOffset ExpireDate { get; set; }
        public TypeCooperation TypeCooperation { get; set; }
        public decimal WorkExperience { get; set; }
        public Workplace Workplace { get; set; }
        public string Advantages { get; set; }
        public Education Education { get; set; }
        public SeniorityLevel SeniorityLevel { get; set; }
        public IndustryType IndustryType { get; set; }
        public JobCategory JobCategory { get; set; }

        //Relations
        public Employer Employer { get; set; }
        public int EmployerId { get; set; }

        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
