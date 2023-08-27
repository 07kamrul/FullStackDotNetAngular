using AutoMapper;
using Microsoft.EntityFrameworkCore;
using FullStackDotNetAngular.Models;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;

namespace FullStackDotNetAngular.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public Employee GetEmployee(int empCode)
        {
            var employee = _context.Employee.Find(empCode);
            if(employee == null)
            {
                throw new KeyNotFoundException("Employee not found.");
            }
            else
            {
                return employee;
            }                
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

        public Employee UpdateEmployee(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Detached;
            _context.Set<Employee>().Update(employee);
            _context.SaveChanges();

            return employee;
        }

        public void RejectEmployee(Employee employee)
        {
            /*_context.Entry(employee).State = EntityState.Detached;
            _context.Set<Employee>().Remove(employee);
            _context.SaveChanges();*/

            _context.Employee.Remove(employee);
            _context.SaveChangesAsync();



        }

    }
}
