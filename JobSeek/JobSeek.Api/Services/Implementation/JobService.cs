using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using Mapster;

namespace JobSeek.Api.Services.Implementation
{
    public class JobService : BaseService<Job, JobInput>
    {
        private readonly IBaseRepository<Job> _repository;

        public JobService(IBaseRepository<Job> repository) : base(repository)
        {
            _repository = repository;
        }

        public Job Create(JobInput input)
        {
            var job = input.Adapt<Job>();
            var JobId = _repository.GetById(job.Id);
            if (JobId != null)
                throw new Exception("This job already exists");
            if (job.MinSalary >= 0)
                throw new Exception("The minimum value cannot be 0");
            
            var DateNow = DateTimeOffset.Now;
            if (job.ExpireDate < DateNow)
                throw new Exception("The expiration date must not be in the past");

            return _repository.Create(job);

        }

        public Job Update(int id, JobInput input)
        {
            var job = input.Adapt<Job>();
            var jobId = _repository.GetById(id);
            if (jobId == null || jobId.Id != job.Id)
                throw new Exception("There is no ID!");
            var DateNow = DateTimeOffset.Now;
            if (DateNow < job.ExpireDate)
                throw new Exception("The expiration date cannot be in the past");
            return _repository.Update(id, job);
        }
        public bool Delete(int id)
        {
            var JobId = _repository.GetById(id);
            if (JobId != null)
                return true;
            else
                return false;
        }
    }
}
