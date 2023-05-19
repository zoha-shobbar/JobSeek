using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;
using System.Data;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployerService : BaseService<Employer, EmployerInput>, IEmployerService
    {
        public EmployerService(IBaseRepository<Employer> repository) : base(repository)
        { }
        public override Employer Create(EmployerInput input)
        {
            var employer = GetAll()
                .Where(x => x.RegisterId == input.RegisterId)
                .Any();
            if (employer) throw new Exception("the employer alredy exist");

            return Create(input);
        }

        public override Employer Update(int id, EmployerInput input)
        {
            var existedEmployer = GetById(id);

            if (existedEmployer == null) throw new Exception("not found!");

            var isRegisterIdExist = GetAll()
               .Where(x => x.RegisterId == input.RegisterId && x.Id != id)
               .Any();

            if (isRegisterIdExist) throw new Exception("the RegisterId alredy exist");

            return Update(id, input);
        }

        public override bool Delete(int id)
        {
            var existedEmployer = GetById(id);

            if (existedEmployer == null) throw new Exception("not found!");

            var Employer = GetAll<Job>()
                .Where(x => x.EmployerId == id)
                .Any();

            if (Employer) throw new Exception("alredy in use");

            return Delete(id);
        }
    }
}