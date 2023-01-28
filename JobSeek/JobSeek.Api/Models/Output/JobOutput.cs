namespace JobSeek.Api.Models.Input
{
    public class JobOutput
    {
        public string Details { get; set; }
        public string PositionTitle { get; set; }
        public string Status { get; set; }
        public int Salary { get; set; }
        public DateTimeOffset ExpireDate { get; set; }
    }
}
