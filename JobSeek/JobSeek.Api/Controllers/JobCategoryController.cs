using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobCategoryController : ControllerBase
    {
        private readonly IJobCategoryRepository repository;

        public JobCategoryController(IJobCategoryRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<JobCategory> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public JobCategory Get(int id)
        {
            return repository.GetById(id);
        }


        [HttpPost]
        public JobCategory Create(JobCategory input)
        {
            return repository.Create(input);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return repository.Delete(id);
        }
    }
}
