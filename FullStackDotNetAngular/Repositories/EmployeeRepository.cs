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
            var employee = _context.Employees.AsNoTracking().Where(e => e.EmpCode == empCode).FirstOrDefault();
            if(employee == null)
            {
                return new Employee();
            }
            else
            {
                return employee;
            }                
        }

        public List<Employee> GetEmployees()
        {            
            return _context.Employees.AsNoTracking().ToList();
        }

        public Employee SaveEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
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

            _context.Employees.Remove(employee);
            _context.SaveChangesAsync();



        }

    }
}
