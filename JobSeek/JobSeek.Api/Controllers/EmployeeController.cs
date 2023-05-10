using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{

    public class EmployeeController : BaseController<IEmployeeService, Employee, EmployeeInput>
    {
        public EmployeeController(IEmployeeService service) : base(service)
        {
        }
    }
}
