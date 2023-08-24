using FullStackDotNetAngular.Models;

namespace FullStackDotNetAngular.Repositories
{
    public interface IEmployeeRepository
    {
       List<Employee> GetEmployees();
       Employee SaveEmployee(Employee employee);
    }
}
