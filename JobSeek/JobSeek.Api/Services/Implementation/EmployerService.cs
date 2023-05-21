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
            var employer = GetAll()
                .Where(x => x.RegisterId == input.RegisterId)
                .Any();
            if (employer) return ListRespons<Employer>.Failed(ResponsStatus.UnknownError);

            var entity = input.Adapt<Employer>();
            return CreateData(input);
        }

        public ListRespons<Employer> UpdateData(int id, EmployerInput input)
        {
            var existedEmployer = GetById(id);
            if (existedEmployer == null) return ListRespons<Employer>.Failed(ResponsStatus.NotFound);

            var isRegisterIdExist = GetAll()
               .Where(x => x.RegisterId == input.RegisterId && x.Id != id)
               .Any();
            if (isRegisterIdExist) return ListRespons<Employer>.Failed(ResponsStatus.UnknownError);

            var entity = input.Adapt<Employer>();
            return UpdateData(id, input);
        }

        public SingleRespons<Employer> DeleteData(int id)
        {
            var existedEmployer = GetById(id);

            if (existedEmployer == null) return SingleRespons<Employer>.Failed(ResponsStatus.NotFound);

            var Employer = GetAll<Job>()
                .Where(x => x.EmployerId == id)
                .Any();
            if (Employer) return SingleRespons<Employer>.Failed(ResponsStatus.UnknownError);

            return DeleteData(id);
        }
    }
}