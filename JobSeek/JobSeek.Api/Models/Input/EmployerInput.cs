namespace JobSeek.Api.Models.Input
{
    public class EmployerInput:UserInput
    {
        public string CompanyName { get; set; }
        public string RegisterId { get; set; }
        public string CompanyLicenseNumber { get; set; } 
        public string NumberOfCompanyMembers { get; set; }
        public string JobField { get; set; }
        public string? SiteAddress { get; set; }
        public string? ImageAddressUrl { get; set; }
    }
}
