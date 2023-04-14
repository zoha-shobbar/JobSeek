using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using Mapster;
using NuGet.Protocol.Core.Types;
using System.Data;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployerService : BaseService<Employer, EmployerInput>
    {
        public EmployerService(IBaseRepository<Employer> repository) : base(repository)
        {
        }
        private readonly IBaseRepository<Employee> _repository;


        public Employer Create(EmployerInput input)
        {
            var employer = GetAll()
                .Where(x => x.RegisterId == input.RegisterId)
                .Any();

            Regex regex = new Regex(@"[\d]");

            if (employer) throw new Exception("There is a desired employer");

            if (input.RegisterId.ToString().Trim().Length >= 2 && regex.IsMatch(input.RegisterId)) throw new Exception("The desired RegisterId is allowed");

            return Create(input);
        }

        public Employer Update(int id, EmployerInput input)
        {
            var existedEmployer = _repository.GetById(id);

            if (existedEmployer == null) throw new Exception("this is not found!");

            var isRegisterIdExist = GetAll()
               .Where(x => x.RegisterId == input.RegisterId && x.Id != id)
               .Count();
            Regex regex = new Regex(@"[\d]");

            if (input.RegisterId.ToString().Trim().Length >= 2 && regex.IsMatch(input.RegisterId)) throw new Exception("The desired RegisterId is allowed");

            return Update(id, input);
        }

        public bool Delete(int id)
        {
            var existedEmployer = _repository.GetById(id);

            if (existedEmployer == null) throw new Exception("this is not found!");

            var Employer = GetAll<Job>()
                .Where(x => x.EmployerId == id)
                .Any();

            if (Employer) throw new Exception("alredy in use");

            return Delete(id);
        }
    }
}



