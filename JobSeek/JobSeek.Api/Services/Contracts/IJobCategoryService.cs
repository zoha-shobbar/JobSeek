using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;

namespace JobSeek.Api.Services.Contracts
{
    public interface IJobCategoryService
    {
        JobCategory Create(JobCategoryInput input);
        bool Delete(int id);
        List<JobCategory> GetAll();
        JobCategory GetById(int id);
        JobCategory Update(int id, JobCategoryInput input);
    }
}