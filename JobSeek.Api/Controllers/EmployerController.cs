using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;

namespace JobSeek.Api.Controllers
{
    public class EmployerController : BaseController<IEmployerService, Employer, EmployerInput>
    {
        public EmployerController(IEmployerService service) : base(service)

        { }
    }
}
