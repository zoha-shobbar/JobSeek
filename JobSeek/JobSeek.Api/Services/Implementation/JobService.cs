using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;
using Mapster;

namespace JobSeek.Api.Services.Implementation
{
    public class JobService : IJobSerivce
    {
        private readonly IJobRepository _repository;

        public JobService(IJobRepository repository) 
        {
            _repository = repository;
        }
        public List<Job> GetAll()
        {
            return _repository.GetAll();
        }

        public Job GetById(int id)
        {
            return _repository.GetById(id);
        }
        
        public Job Create(JobInput input)
        {
            return _repository.Create(input);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Job Update(int id, JobInput input)
        {
            var entityJob = _repository.GetById(id);
            if (entityJob == null)
                throw new Exception("this is not found!");
            return _repository.Update(id, input);
        }
    }
}
