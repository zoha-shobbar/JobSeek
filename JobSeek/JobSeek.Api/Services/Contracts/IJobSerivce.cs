using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;

namespace JobSeek.Api.Services.Contracts
{
    public interface IJobSerivce
    {
        List<Job> GetAll();
        Job GetById(int id);
        Job create(Job job);
        bool delete(int id);
    }
}
