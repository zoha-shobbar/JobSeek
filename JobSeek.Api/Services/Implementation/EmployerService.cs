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

        public override SingleResponse<Employer> Create(EmployerInput input)
        {
            var result = Get()
                .Where(x => x.RegisterId == input.RegisterId)
                .Any();

            if (result) return ResponseStatus.AlreadyExist;

            return Create(input);
        }

        public override SingleResponse<Employer> Update(int id, EmployerInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var resultExist = Get()
                .Where(x => x.RegisterId == input.RegisterId && x.Id != id)
                .Any();

            if (resultExist) return ResponseStatus.AlreadyExist;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;
          
            var resultExist = Get<Job>()
               .Where(x => x.EmployerId == id)
                .Any();

            if (resultExist) return ResponseStatus.UnknownError;

            return Delete(id);
        } 
    }
}