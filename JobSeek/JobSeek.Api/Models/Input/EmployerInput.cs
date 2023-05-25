using JobSeek.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Models.Input
{
    public class EmployerInput : UserInput
    {
        public string CompanyName { get; set; }
        [RegisterId]
        public string RegisterId { get; set; }
        [Display(Name = "Company License Number"),StringLength(10)]
        public string CompanyLicenseNumber { get; set; }
        [Display(Name = "Number Of Company Members")]
        public int NumberOfCompanyMembers { get; set; }
        public string JobField { get; set; }
        [Url]
        public string? SiteAddress { get; set; }
        public string? ImageAddressUrl { get; set; }
    }
}
