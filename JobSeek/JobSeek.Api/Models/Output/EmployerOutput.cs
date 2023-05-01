using JobSeek.Api.Models.Output;

namespace JobSeek.Api.Models.Output
{
    public class EmployerOutput : UserOutput
    {
        public string CompanyName { get; set; }
        public int CompanyEmployerNumber { get; set; }
        public string JobField { get; set; }
        public string? SiteAddress { get; set; }
        public string? ImageAddressUrl { get; set; }

    }
}
