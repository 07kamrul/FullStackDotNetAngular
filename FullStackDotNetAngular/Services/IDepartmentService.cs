using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;

namespace FullStackDotNetAngular.Services
{
    public interface IDepartmentService
    {
        List<DepartmentResponseModel> GetDepartments();
        DepartmentResponseModel SaveDepartment(DepartmentRequestModel departmentRequest);
    }
}
