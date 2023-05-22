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
            var result = GetAll()
                .Where(x => x.RegisterId == input.RegisterId)
                .Any();
            if (result) return ListRespons<Employer>.Failed(ResponsStatus.UnknownError);

            var entity = input.Adapt<Employer>();
            return CreateData(entity);
        }

        public ListRespons<Employer> UpdateData(int id, EmployerInput input)
        {
            var result = GetById(id);
            if (result == null) return ListRespons<Employer>.Failed(ResponsStatus.NotFound);

            var resultExist = GetAll()
               .Where(x => x.RegisterId == input.RegisterId && x.Id != id)
               .Any();
            if (resultExist) return ListRespons<Employer>.Failed(ResponsStatus.UnknownError);

            var entity = input.Adapt<Employer>();
            return UpdateData(id,entity);
        }

        public SingleRespons<bool> DeleteData(int id)
        {
            var result = GetById(id);

            if (result == null) return SingleRespons<bool>.Failed(ResponsStatus.NotFound);

            var resultExist = GetAll<Job>()
                .Where(x => x.EmployerId == id)
                .Any();
            if (resultExist) return SingleRespons<bool>.Failed(ResponsStatus.Failed);

            return DeleteData(id);
        }
    }
}