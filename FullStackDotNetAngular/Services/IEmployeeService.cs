using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;

namespace FullStackDotNetAngular.Services
{
    public interface IEmployeeService
    {
        EmployeeResponseModel GetEmployee(int empCode);
        List<EmployeeResponseModel> GetEmployees();
        void RejectEmployee(int id);
        EmployeeResponseModel SaveEmployee(EmployeeRequestModel employeeRequest);
        EmployeeResponseModel UpdateEmployee(EmployeeRequestModel employeeRequest);
    }
}
