using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Mapster;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeService _employee;

        public EmployeeService(IEmployeeService employee)
        {
            _employee = employee;
        }
        public List<Employee> GetAll()
        {
           return _employee.GetAll();
        }

        public Employee GetById(int id)
        {
           return _employee.GetById(id);
        }
        public Employee Create(EmployeeInput input)
        {
            var entity = input.Adapt<Employee>();

            return _employee.Create(entity);
        }

        public bool Delete(int id)
        {
            var entity = _employee.GetById(id);
            if (entity == null)
                throw new Exception("this is not found!");
            return _employee.Delete(id);
        }


        public Employee Update(int id, EmployeeInput input)
        {
            var existedEntity = _employee.GetById(id);

            if (existedEntity == null)
                throw new Exception("this is not found!");

            Employee entity = input.Adapt<Employee>();

            return _employee.Update(id, entity);
        }
    }
}
