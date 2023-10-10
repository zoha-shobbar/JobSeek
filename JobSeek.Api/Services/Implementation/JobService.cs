using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Responses;
using JobSeek.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace JobSeek.Api.Services.Implementation
{
    public class JobService : BaseService<Job, JobInput>, IJobService
    {
        public JobService(IBaseRepository<Job> repository) : base(repository)
        { }
        public override SingleResponse<Job> Create(JobInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<Job> Update(int id, JobInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var resultExist = Get<Employer>()
               .Where(x => x.Id == id)
                .Any();

            if (resultExist) return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}