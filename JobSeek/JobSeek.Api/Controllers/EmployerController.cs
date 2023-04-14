using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    public class EmployerController : BaseController<IBaseService<Employer, EmployerInput>, Employer, EmployerInput>
    {
        public EmployerController(IBaseService<Employer, EmployerInput> service) : base(service)
        {
        }
    }
}
