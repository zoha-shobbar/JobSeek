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

        [HttpGet("[action]")]
        public SingleRespons<Employer> GetByIdData(int id)
        {
            return _service.GetByIdData(id);
        }

        [HttpPost("[action]")]
         public ListRespons<Employer> CreateData(Employer input)
         {
            return _service.CreateData(input);
         }

        [HttpPut("[action]")]
        public ListRespons<Employer> UpdateData(int id, EmployerInput input)
        {
           return _service.UpdateData(id,input);
        }

        [HttpDelete("[action]")]
        public SingleRespons<Employer> DeleteData(int id)
        {
            return _service.DeleteData(id);
        }
    }
}
