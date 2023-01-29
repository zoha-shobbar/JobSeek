﻿using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Job : BaseEntity
    {
        public string Details { get; set; }
        public string PositionTitle { get; set; }
        public Enum Status { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public DateTimeOffset ExpireDate { get; set; }
        public Enum TypeCooperation { get; set; }
        public Enum ContractType { get; set; }
        public Enum WorkExperience { get; set; }
        public Enum Workplace { get; set; }
        public Enum Advantages { get; set; }
        public Enum Grade { get; set; }
        public Enum SeniorityLevel { get; set; }
        public Enum TypeIndustry { get; set; }



        //Relations
        public Employer Employer { get; set; }
        public int EmployerId { get; set; }

        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
