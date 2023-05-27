using JobSeek.Api.Enums;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Models.Input
{
    public class JobInput
    {
        public string Details { get; set; }
        public string PositionTitle { get; set; }
        public JobStatus JobStatus { get; set; }
        [Range(0,int.MinValue)]
        public int MinSalary { get; set; }
        [Range(int.MinValue, int.MaxValue)]
        public int MaxSalary { get; set; }
        [ExpireDate]
        public DateTimeOffset ExpireDate { get; set; }
        public TypeCooperation TypeCooperation { get; set; }
        [Range(0,30)]
        public decimal WorkExperience { get; set; }
        public Workplace Workplace { get; set; }
        public string Advantages { get; set; }
        public Education Education { get; set; }
        public SeniorityLevel SeniorityLevel { get; set; }
        public IndustryType IndustryType { get; set; }
        public JobCategory JobCategory { get; set; }
    }
}
