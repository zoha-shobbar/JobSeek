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
        public SingleResponse<Employee> Create(EmployeeInput input)
        {
            
            var isEmailExist = GetAll().Where(x => x.Email == input.Email).Any();
            if (isEmailExist)
                return SingleResponse<Employee>.Failed(ResponseStatus.alreadyExist);

            var isPhoneNumberExist = GetAll().Where(x => x.PhoneNumber == input.PhoneNumber).Any();
            if (isPhoneNumberExist)
                return SingleResponse<Employee>.Failed(ResponseStatus.alreadyExist);

            var isNationalcodeExist = GetAll().Where(x => x.NatioanlCode == input.NatioanlCode).Any();
            if (isNationalcodeExist)
                return SingleResponse<Employee>.Failed(ResponseStatus.alreadyExist);

            var employee = input.Adapt<Employee>();
            return SingleResponse<Employee>.Success(_repository.Create(employee));

        }

        public SingleResponse<Employee> Update(int id, EmployeeInput input)
        {
           
            //Phone Number
            var isPhoneExist = GetAll()
                .Where(x => x.PhoneNumber == input.PhoneNumber && x.Id != id)
                .Any();
            if (isPhoneExist)
                return SingleResponse<Employee>.Failed(ResponseStatus.alreadyExist);

            //Email
            var isEmailExist = GetAll()
                .Where(x => x.Email == input.Email && x.Id != id)
                .Any();
            if (isEmailExist)
                return SingleResponse<Employee>.Failed(ResponseStatus.alreadyExist);

            //National Code
            var isNationalcodeExist = GetAll()
                .Where(x => x.NatioanlCode == input.NatioanlCode)
                .Any();
            if (isNationalcodeExist)
                return SingleResponse<Employee>.Failed(ResponseStatus.alreadyExist);

            var employee = input.Adapt<Employee>();
            return SingleResponse<Employee>.Success(_repository.Update(id, employee));
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
