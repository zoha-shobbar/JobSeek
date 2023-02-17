using JobSeek.Api.Models.Entities;

namespace JobSeek.Api.Repository.Contracts
{
    public interface IJobCategoryRepository
    {
        List<JobCategory> GetAll();
        JobCategory GetById(int id);
        JobCategory Create(JobCategory jobCategory);
        bool Delete(int jobCategoryId);
    }
}
