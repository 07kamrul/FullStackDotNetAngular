using FullStackDotNetAngular.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStackDotNetAngular.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataContext _context;
        public DepartmentRepository(DataContext context)
        {
            _context = context;
        }

        public List<Department> GetDepartments()
        {
            return _context.Departments.AsNoTracking().ToList();
        }

        public Department SaveDepartment(Department dept)
        {
            _context.Departments.Add(dept);
            _context.SaveChanges();
            return dept;
        }
    }
}
