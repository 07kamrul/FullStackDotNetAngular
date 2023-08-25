using FullStackDotNetAngular.Models;

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
            return _context.Department.ToList();
        }

        public Department SaveDepartment(Department dept)
        {
            _context.Department.Add(dept);
            _context.SaveChanges();
            return dept;
        }
    }
}
