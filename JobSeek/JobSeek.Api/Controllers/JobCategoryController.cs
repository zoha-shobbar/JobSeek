using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobCategoryController : ControllerBase
    {
        private readonly IJobCategoryService service;

        public JobCategoryController(IJobCategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public List<JobCategory> Get()
        {
            return service.GetAll();
        }

        [HttpGet("{id}")]
        public JobCategory Get(int id)
        {
            return service.GetById(id);
        }


        [HttpPost]
        public JobCategory Create(JobCategoryInput input)
        {
            return service.Create(input);
        }

        //deleted api
        [HttpDelete]
        public bool Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
