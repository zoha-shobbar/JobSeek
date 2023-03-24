using JobSeek.Api.Models.Entities;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : IJobSerivce
    {
        private readonly IJobSerivce _jobSerivce;

        public JobsController(IJobSerivce jobSerivce)
        {
            this._jobSerivce = jobSerivce;
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
        public Job create(Job job)
        {
          return _jobSerivce.create(job);
        }

        [HttpDelete]
        public bool delete(int id)
        {
            return _jobSerivce.delete(id);   
        }

    }
}
