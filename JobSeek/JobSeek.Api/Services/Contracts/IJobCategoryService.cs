using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;

namespace JobSeek.Api.Services.Contracts
{
    public interface IJobCategoryService
    {
        List<JobCategory> GetAll();
        JobCategory GetById(int id);
        JobCategory Create(JobCategoryInput input);
        JobCategory Update(int id, JobCategoryInput input);
        bool Delete(int id);
    }
}