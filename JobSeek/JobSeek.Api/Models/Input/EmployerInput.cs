namespace JobSeek.Api.Models.Input
{
    public class EmployerInput:UserInput
    {
        public string RegisterId { get; set; }
        public int CompanyEmployerNumber { get; set; }
        public string CompanyName { get; set; }
        public string JobField { get; set; }
        public string? SiteAddress { get; set; }
        public string? ImageUrl { get; set; }
    }
}
