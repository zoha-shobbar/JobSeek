using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Responses;
using JobSeek.Api.Services.Contracts;
using Mapster;
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

        public ListRespons<Employer> GetAllData()
        {
            var result = GetAll();

            if (!result.Any())
                return ListRespons<Employer>.Failed(ResponsStatus.NotFound);

            return ListRespons<Employer>.Success(result);
        }

        public SingleRespons<Employer> GetByIdData(int id)
        {
            var result = GetById(id);
            if (result == null)
                return SingleRespons<Employer>.Failed(ResponsStatus.NotFound);

            return SingleRespons<Employer>.Success(result);
        }

        public ListRespons<Employer> CreateData(Employer input)
        {
            var result = GetAll()
                .Where(x => x.RegisterId == input.RegisterId)
                .Any();
            if (!result) return ListRespons<Employer>.Failed(ResponsStatus.Failed);

            var entity = input.Adapt<Employer>();
            return CreateData(input);
        }

        public ListRespons<Employer> UpdateData(int id, EmployerInput input)
        {
            var result = GetById(id);
            if (result == null) return ListRespons<Employer>.Failed(ResponsStatus.NotFound);

            var resultExist = GetAll()
               .Where(x => x.RegisterId == input.RegisterId && x.Id != id)
               .Any();
            if (resultExist) return ListRespons<Employer>.Failed(ResponsStatus.Failed);

            var entity = input.Adapt<Employer>();
            return UpdateData(id, input);
        }

        public SingleRespons<Employer> DeleteData(int id)
        {
            var result = GetById(id);

            if (result == null) return SingleRespons<Employer>.Failed(ResponsStatus.NotFound);

            var resultExist = GetAll<Job>()
                .Where(x => x.EmployerId == id)
                .Any();
            if (resultExist) return SingleRespons<Employer>.Failed(ResponsStatus.Failed);

            return DeleteData(id);
        }
    }
}