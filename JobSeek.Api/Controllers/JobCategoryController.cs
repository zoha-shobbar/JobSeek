using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;

namespace JobSeek.Api.Controllers
{
    public class JobCategoryController : BaseController<IBaseService<JobCategory, JobCategoryInput>, JobCategory, JobCategoryInput>
    {
        public JobCategoryController(IBaseService<JobCategory, JobCategoryInput> service) : base(service)
        {
        }
    }
}
