﻿using JobSeek.Api.Enums;

namespace JobSeek.Api.Models.Entities
{
    public class Employee : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SeniorityLevel MajoringIn { get; set; }
        public Education Degree { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public Gender Gender { get; set; }
        public int MaritalStatus { get; set; }
        public MilitaryService MilitaryService { get; set; }

        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
