using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Responses;

namespace JobSeek.Api.Services.Contracts
{
    public interface IEmployerService : IBaseService<Employer, EmployerInput>
    {
        ListRespons<Employer> GetAllData();
    }

}
