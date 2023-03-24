using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;

namespace JobSeek.Api.Services.Implementation
{
    public class JobService : IJobSerivce
    {
        private readonly IJobRepository _repository;

        public JobService(IJobRepository repository) 
        {
            this._repository = repository;
        }
        public List<Job> GetAll()
        {
            return _repository.GetAll();
        }

        public Job GetById(int id)
        {
            return _repository.GetById(id);
        }
        
        public Job create(Job job)
        {
            return _repository.create(job);
        }

        public bool delete(int id)
        {
            var ExistEntity = _repository.delete(id);
            if (id == null)
                throw new Exception("this is not found!");
            return ExistEntity;
        }
    }
}
