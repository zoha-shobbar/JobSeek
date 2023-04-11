using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using System.Data;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployerService : BaseService<Employer, EmployerInput>
    {
        public EmployerService(IBaseRepository<Employer> repository) : base(repository)
        {
        }

        public Employer Create(EmployerInput input)
        {
            var employer = GetAll().Where(x => x.RegisterId == input.RegisterId)
                .FirstOrDefault();
            if (employer != null)
            {
                throw new Exception("There is a desired employer");
            }
            return Create(input);
        }
    }
}



