using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class Administrator: User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
