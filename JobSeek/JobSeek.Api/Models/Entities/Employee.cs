using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Employee : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MajoringIn { get; set; }
        public string Degree { get; set; }
        public DateTimeOffset DateBirth { get; set; }
        public string NationalCode { get; set; }
        public float Average { get; set; }
        public DateTimeOffset GraduationDate { get; set; }
        public string University { get; set; }
        public Enum Gender { get; set; }
        public Enum MaritalStatus { get; set; }
        public Enum MilitaryService { get; set; }



        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
