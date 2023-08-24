using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;

namespace FullStackDotNetAngular.Services
{
    public interface IEmployeeService
    {
        List<EmployeeResponseModel> GetEmployees();
        EmployeeResponseModel SaveEmployee(EmployeeRequestModel employeeRequest);
    }
}
