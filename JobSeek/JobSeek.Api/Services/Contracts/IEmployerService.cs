using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;

namespace JobSeek.Api.Services.Contracts
{
    public interface IEmployerService : IBaseService<Employer, EmployerInput>
    { }
}