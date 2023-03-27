using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository.Contracts;

namespace JobSeek.Api.Repository
{
    public class EmploeeRepository : IEmployeeRepository
    {
        private readonly DataContext _dataContext;

        public EmploeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Employee> GetAll()
        {
            return _dataContext.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            var employee = _dataContext.Employees
                .Where(x => x.Id == id)
                .FirstOrDefault();

            return employee;
        }
        public Employee Create(Employee input)
        {
            _dataContext.Employees.Add(input);
            _dataContext.SaveChanges();
            return input;
        }

        public Employee Update(int id, Employee input)
        {
            var employee = _dataContext.Employees
                .Where(x => x.Id == id)
                .FirstOrDefault();
            
            employee.Email = input.Email;
            employee.PhoneNumber = input.PhoneNumber;
            employee.Password = input.Password;
            employee.Address = input.Address;
            employee.PostalCode = input.PostalCode;
            employee.FirstName = input.FirstName;
            employee.LastName = input.LastName;
            employee.SeniorityLevel = input.SeniorityLevel;
            employee.Education = input.Education;
            employee.BirthDate = input.BirthDate;
            employee.Gender = input.Gender;
            employee.MaritalStatus = input.MaritalStatus;
            employee.MilitaryService = input.MilitaryService;

            _dataContext.SaveChanges();
            return employee;
        }
        public Employee Delete(int id)
        {
            var employee = _dataContext.Employees
                .Where(x => x.Id == id)
                .FirstOrDefault();

            _dataContext.Employees.Remove(employee);
            _dataContext.SaveChanges();

            return employee;
        }


    }
}
