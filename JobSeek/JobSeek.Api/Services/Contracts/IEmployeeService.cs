using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;

namespace JobSeek.Api.Services.Contracts
{
    public interface IEmployeeService
    {

        List<Employee> GetAll();
        Employee GetById(int id);
        Employee Create(EmployeeInput input);
        Employee Update(int id ,EmployeeInput input);
        bool Delete(int id);
    }
}
