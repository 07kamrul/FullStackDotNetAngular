using AutoMapper;
using FullStackDotNetAngular.Models;
using FullStackDotNetAngular.Repositories;
using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;

namespace FullStackDotNetAngular.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public List<EmployeeResponseModel> GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();
            return _mapper.Map<List<EmployeeResponseModel>>(employees);
        }

        public EmployeeResponseModel SaveEmployee(EmployeeRequestModel employeeRequest)
        {
            var emp = _mapper.Map<Employee>(employeeRequest);
            var employee = _employeeRepository.SaveEmployee(emp);
            return _mapper.Map<EmployeeResponseModel>(employee);
        }
    }
}
