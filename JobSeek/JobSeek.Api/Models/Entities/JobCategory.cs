using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Models.Entities
{
    public class JobCategory : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        //public int? ParentJobCategoryId { get; set; }
        //public JobCategory? ParentJobCategory { get; set; }
    }
}
