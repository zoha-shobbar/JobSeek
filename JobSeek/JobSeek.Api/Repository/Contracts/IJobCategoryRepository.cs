using JobSeek.Api.Models.Entities;

namespace JobSeek.Api.Repository.Contracts
{
    public interface IJobCategoryRepository
    {
        List<JobCategory> GetAll();
        JobCategory Create(JobCategory jobCategory);
        bool Delete(int jobCategoryId);
    }
}
