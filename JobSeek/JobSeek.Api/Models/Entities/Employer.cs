using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Employer : User
    {
        public string CompanyName { get; set; }
        public string RegisterId { get; set; }
        public int CompanyEmployerNumber { get; set; }
        public string JobField { get; set; }


        //Collections
        public ICollection<Job> Jobs { get; set; }
    }
}
