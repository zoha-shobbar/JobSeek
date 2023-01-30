using JobSeek.Api.Models.Entities.Common;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace JobSeek.Api.Models.Entities
{
    public class Employer : User
    {
        public string CompanyName { get; set; }
        public string RegisterId { get; set; }
        public int CompanyEmployerNumber { get; set; }
        public string JobField { get; set; }
        public string? SiteAddress { get; set; }
        public string? ImageAddressUrl{ get; set; }

        //Collections
        public ICollection<Job> Jobs { get; set; }
    }
}
