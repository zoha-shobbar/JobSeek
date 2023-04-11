using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{

    public class EmployeeController : BaseController<IBaseService<Employee, EmployeeInput>, Employee, EmployeeInput>
    {
        public EmployeeController(IBaseService<Employee, EmployeeInput> service) : base(service)
        {
        }
    }
}
