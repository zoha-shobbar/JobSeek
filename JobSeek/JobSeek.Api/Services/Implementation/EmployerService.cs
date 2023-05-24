using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Responses;
using JobSeek.Api.Services.Contracts;
using System.Data;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployerService : BaseService<Employer, EmployerInput>, IEmployerService
    {
        public EmployerService(IBaseRepository<Employer> repository) : base(repository)
        { }

        public override ListRespons<Employer> Create(EmployerInput input)
        {
            var result = GetAll<Employer>()
                .Where(x => x.RegisterId == input.RegisterId)
                .Any();
            if (result) return ListRespons<Employer>.Failed(ResponsStatus.UnknownError);

            return Create(input);
        }

        public override ListRespons<Employer> Update(int id, EmployerInput input)
        {
            var existedEmployer = GetById(id);

            var result = GetById(id);
            if (result == null) return ListRespons<Employer>.Failed(ResponsStatus.NotFound);
            var resultExist = GetAll<Employer>()
                .Where(x => x.RegisterId == input.RegisterId && x.Id != id)
                .Any();

            if (resultExist) return ListRespons<Employer>.Failed(ResponsStatus.UnknownError);

            return Update(id, input);
        }

        public override SingleRespons<bool> Delete(int id)
        {
            var result = GetById(id);

            if (result == null) return SingleRespons<bool>.Failed(ResponsStatus.NotFound);

            var resultExist = GetAll<Job>()
                .Where(x => x.EmployerId == id)
                .Any();

            if (resultExist) return SingleRespons<bool>.Failed(ResponsStatus.Failed);
            return Delete(id);
        }
    }
}