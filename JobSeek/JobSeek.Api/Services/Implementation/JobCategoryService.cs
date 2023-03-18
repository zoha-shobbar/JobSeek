using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;
using Mapster;

namespace JobSeek.Api.Services.Implementation
{
    public class JobCategoryService : IJobCategoryService
    {
        private readonly IJobCategoryRepository _repository;

        public JobCategoryService(IJobCategoryRepository repository)
        {
            _repository = repository;
        }


        public JobCategory Create(JobCategoryInput input)
        {
            JobCategory entity = input.Adapt<JobCategory>();

            return _repository.Create(entity);
        }

        public bool Delete(int id)
        {
           return _repository.Delete(id);   
        }

        public List<JobCategory> GetAll()
        {
            return _repository.GetAll();
        }

        public JobCategory GetById(int id)
        {
            return _repository.GetById(id);
        }

        public JobCategory Update(int id, JobCategoryInput input)
        {
            JobCategory entity = input.Adapt<JobCategory>();
            return _repository.Update(id,entity);
        }
    }
}