using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController<IBaseService<Job, Models.Input.JobInput>, Job, Models.Input.JobInput>
    {
        public EmployeeController(IBaseService<Job, Models.Input.JobInput> service) : base(service)
        {
        }
    }
}
