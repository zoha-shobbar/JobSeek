using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Employee : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Collections
        public ICollection<JobEmployee> JobEmployees { get; set; }
    }
}
