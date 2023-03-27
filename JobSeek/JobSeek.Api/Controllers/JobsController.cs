using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : IBaseSerivce<Job,JobInput>
    {
        private readonly IBaseSerivce<Job, JobInput> _jobSerivce;

        public JobsController(IBaseSerivce<Job, JobInput> jobSerivce)
        {
            _jobSerivce = jobSerivce;
        }

        [HttpGet]
        public List<Job> GetAll()
        {
            return _jobSerivce.GetAll();
        }

        [HttpGet("id")]
        public Job GetById(int id)
        {
            return _jobSerivce.GetById(id);
        }

        [HttpPost]
        public Job Create(JobInput job)
        {
          return _jobSerivce.Create(job);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _jobSerivce.Delete(id);   
        }

        [HttpPut]
        public Job Update(int id, JobInput job)
        {
            return _jobSerivce.Update(id, job);
        }
    }
}
