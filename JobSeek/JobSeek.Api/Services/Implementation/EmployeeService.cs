using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Responses;
using JobSeek.Api.Validations;
using Mapster;
using System.Text.RegularExpressions;

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
            
            var email = GetAll().Where(x => x.Email == input.Email).Any();
            if (email)
                SingleResponse<Employee>.Failed(ResponseStatus.Faild);

            var phoneNumber = GetAll().Where(x => x.PhoneNumber == input.PhoneNumber).Any();
            if (phoneNumber)
                SingleResponse<Employee>.Failed(ResponseStatus.Faild);

            var nationalcode = GetAll().Where(x => x.NatioanlCode == input.NatioanlCode).Any();
            if (nationalcode)
                SingleResponse<Employee>.Failed(ResponseStatus.Faild);

            var employee = input.Adapt<Employee>();
            return _repository.Create(employee);

        }

        public Employee Update(int id, EmployeeInput input)
        {
           
            //Phone Number
            var isPhoneExist = GetAll()
                .Where(x => x.PhoneNumber == input.PhoneNumber && x.Id != id)
                .Any();
            if (isPhoneExist) throw new Exception("Your email is already in use");

            //Email
            var isEmailExist = GetAll()
                .Where(x => x.Email == input.Email && x.Id != id)
                .Any();
            if (isEmailExist) throw new Exception("Your email is already in use");

            //National Code
            var nationalcode = GetAll()
                .Where(x => x.NatioanlCode == input.NatioanlCode)
                .Any();
            if (nationalcode) throw new Exception("nationalcode already exists");

            var employee = input.Adapt<Employee>();
            return employee;
        }
        public bool Delete(int id)
        {
            var EmployeeExist = GetAll<JobEmployee>().Where(x => x.EmployeeId == id).Any();
            if (EmployeeExist) throw new Exception("alredy in use");
            return Delete(id);
        }

        public ListResponse<Employee> GetAllData()
        {
            var result =  GetAll();
            if (result == null)
                return ListResponse<Employee>.Failed(ResponseStatus.NotFound);

            return ListResponse<Employee>.Success(result);
        }
    }
}
