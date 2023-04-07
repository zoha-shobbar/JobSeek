using JobSeek.Api.Enums;
using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class JobEmployee : BaseEntity
    {
        public Job Employee { get; set; }
        public int EmployeeId { get; set; }

        public Job Job { get; set; }
        public int JobId { get; set; }

        public CvCheckStatus CvCheckStatus { get; set; }
    }
}
