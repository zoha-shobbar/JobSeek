using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Employee> GetAll()
        {
            return _service.GetAll();
        }
        [HttpGet("id")]
        public Employee GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public Employee Create(EmployeeInput input)
        {
            return _service.Create(input);
        }
        [HttpPut]
        public Employee Update(int id, EmployeeInput input)
        {
            return _service.Update(id, input);
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
