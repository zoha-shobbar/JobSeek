using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using Mapster;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployeeService : BaseService<Employee, EmployeeInput>
    {
        private readonly IBaseRepository<Employee> _repository;

        public EmployeeService(IBaseRepository<Employee> repository) : base(repository)
        {
            _repository = repository;
        }

        public Employee Create(EmployeeInput input)
        {
            var employee = input.Adapt<Employee>();

            var employeeId = _repository.GetById(employee.Id);

            if (employeeId == null)
                throw new Exception("There is no Employee");

            if (employee.Password.Length >= 8)
                throw new Exception("Password must be more than 8 digits");

            if (employee.Email.Contains('@') != false)
                throw new Exception("Your email format is incorrect");

            var dateNow = DateTimeOffset.Now;
            if (employee.ModificationDate < dateNow)
                throw new Exception("The delivery date cannot be earlier than the current date");
            

            return _repository.Create(employee);

        }
        public Employee Update(EmployeeInput input, int id)
        {
            var Employee = input.Adapt<Employee>();

            var employeeId = _repository.GetById(id);
            if (employeeId == null)
                throw new Exception("This person does not exist with this ID");

            if (input.Password.Length > 8)
                throw new Exception("Password must be more than 8 digits");

            if (input.Email.Contains('@') != false)
                throw new Exception("Your email format is incorrect");

            
            return _repository.Update(id,Employee);

        }

        public bool Delete(int id)
        {
            var EmployeeId = _repository.GetById(id);
            if (EmployeeId == null)
                throw new Exception("This employee does not exist with this ID");
            return true;
        }

        
    }
}