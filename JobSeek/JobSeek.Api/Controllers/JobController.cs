using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;

namespace JobSeek.Api.Controllers
{
    public class JobController : BaseController<IJobService, Job, JobInput>
    {
        public JobController(IJobService service) : base(service)
        { }
    }
}
