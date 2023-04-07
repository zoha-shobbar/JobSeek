using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    public class JobController : BaseController<IBaseService<Job, Models.Input.JobInput>,Job, Models.Input.JobInput>
    {
        public JobController(IBaseService<Job, Models.Input.JobInput> service) : base(service) 
        {
        }
    }
}
