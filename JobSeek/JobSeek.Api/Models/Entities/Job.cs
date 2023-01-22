using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Job : BaseEntity
    {
        public string Details { get; set; }
        public string PositionTitle { get; set; }
        public string Status { get; set; }
        public int Salary { get; set; }
        public DateTimeOffset ExpireDate { get; set; }

        //Relations
        public Employer Employer { get; set; }
        public int EmployerId { get; set; }

        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
