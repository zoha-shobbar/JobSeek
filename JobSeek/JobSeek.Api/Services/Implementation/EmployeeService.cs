using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;
using Mapster;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public List<Employee> GetAll()
        {
           return _repository.GetAll();
        }

        public Employee GetById(int id)
        {
           return _repository.GetById(id);
        }
        public Employee Create(EmployeeInput input)
        {
            var entity = input.Adapt<Employee>();

            return _repository.Create(entity);
        }

        public bool Delete(int id)
        {
            var entity = _repository.GetById(id);
            if (entity == null)
                throw new Exception("this is not found!");
            return _repository.Delete(id);
        }


        public Employee Update(int id, EmployeeInput input)
        {
            var existedEntity = _repository.GetById(id);

            if (existedEntity == null)
                throw new Exception("this is not found!");

            Employee entity = input.Adapt<Employee>();

            return _repository.Update(id, entity);
        }
    }
}
