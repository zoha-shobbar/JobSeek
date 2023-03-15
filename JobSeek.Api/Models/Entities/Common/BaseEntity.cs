namespace JobSeek.Api.Models.Entities.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset ModificationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
