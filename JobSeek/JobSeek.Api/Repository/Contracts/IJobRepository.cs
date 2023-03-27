using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;

namespace JobSeek.Api.Repository.Contracts
{
    public interface IJobRepository
    {
        List<Job> GetAll();
        Job GetById(int id);
        bool Delete(int id);
        Job Create(JobInput input);
        Job Update(int id , JobInput job);
    }
}
