using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Responses;

namespace JobSeek.Api.Services.Contracts
{
    public interface IEmployerService : IBaseService<Employer, EmployerInput>
    {
        ListRespons<Employer> GetAllData();
        SingleRespons<Employer> GetByIdData(int id);
        ListRespons<Employer> CreateData(Employer input);
        ListRespons<Employer> UpdateData(int id, EmployerInput input);
        SingleRespons<Employer> DeleteData(int id);
    }
}