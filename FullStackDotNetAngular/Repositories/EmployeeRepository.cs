using AutoMapper;
using Microsoft.EntityFrameworkCore;
using FullStackDotNetAngular.Models;

namespace FullStackDotNetAngular.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployees()
        {            
            return _context.Employee.ToList();
        }

        public Employee SaveEmployee(Employee employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}
