using FullStackDotNetAngular.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullStackDotNetAngular.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int empCode);
        List<Employee> GetEmployees();
        void RejectEmployee(Employee employee);
        Employee SaveEmployee(Employee employee);
        Employee UpdateEmployee(Employee emp);
    }
}
