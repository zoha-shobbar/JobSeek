namespace JobSeek.Api.Models.Output
{
    public abstract class UserOutput
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public string Adress { get; set; }
    }
}
