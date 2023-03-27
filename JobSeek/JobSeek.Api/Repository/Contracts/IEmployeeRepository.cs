using JobSeek.Api.Models.Entities;

namespace JobSeek.Api.Repository.Contracts
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        Employee Create(Employee input);
        Employee Update(int id, Employee input);
        Employee Delete(int id);
    }
}
