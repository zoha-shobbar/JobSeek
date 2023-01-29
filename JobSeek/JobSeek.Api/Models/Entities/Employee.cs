using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Employee : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MajoringIn { get; set; }
        public Enum Degree { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public Enum Gender { get; set; }
        public Enum MaritalStatus { get; set; }
        public Enum MilitaryService { get; set; }



        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
