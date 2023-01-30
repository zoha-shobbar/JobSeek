using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Employee : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enum MajoringIn { get; set; }
        public enum Degree { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public enum Gender { get; set; }
        public enum MaritalStatus { get; set; }
        public enum MilitaryService { get; set; }



        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
