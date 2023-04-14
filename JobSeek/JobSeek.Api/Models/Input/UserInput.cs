namespace JobSeek.Api.Models.Input
{
    public abstract class UserInput
    {
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
