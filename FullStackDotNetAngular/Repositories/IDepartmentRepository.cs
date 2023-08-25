using FullStackDotNetAngular.Models;

namespace FullStackDotNetAngular.Repositories
{
    public interface IDepartmentRepository
    {
        List<Department> GetDepartments();
        Department SaveDepartment(Department dept);
    }
}
