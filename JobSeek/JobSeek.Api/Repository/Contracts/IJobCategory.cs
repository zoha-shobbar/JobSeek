using JobSeek.Api.Models.Entities;

namespace JobSeek.Api.Repository.Contracts
{
    public interface IJobCategory
    {
        List<JobCategory> GetAll();
        JobCategory Create(JobCategory jobCategory);
        bool Delete(int jobCategoryId);
    }
}
