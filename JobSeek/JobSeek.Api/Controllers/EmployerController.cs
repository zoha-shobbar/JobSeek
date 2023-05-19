using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Responses;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    public class EmployerController : BaseController<IEmployerService, Employer, EmployerInput>
    {
        private readonly IEmployerService _service;

        public EmployerController(IEmployerService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public ListRespons<Employer> GetAllData()
        {
            return _service.GetAllData();
        }
    }
}
