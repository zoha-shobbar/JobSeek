using JobSeek.Api.Models.Output;

namespace JobSeek.Api.Models.Input
{
    public class EmployerOutput : output
    {
        public string CompanyName { get; set; }
        public string JobField { get; set; }
        public string? SiteAddress { get; set; }

    }
}
