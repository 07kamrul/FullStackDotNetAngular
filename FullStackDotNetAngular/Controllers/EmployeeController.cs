using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;
using FullStackDotNetAngular.Services;

namespace FullStackDotNetAngular.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetEmployees")]
        public List<EmployeeResponseModel> GetEmployees() 
        {
            try
            {
                var employees = _employeeService.GetEmployees();
                return employees;
            }
            catch(Exception ex)
            {
                throw;
            }
        }


        [HttpPost("SaveEmployee")]
        public EmployeeResponseModel SaveEmployee([FromBody] EmployeeRequestModel employeeRequest)
        {
            try
            {
                if (employeeRequest.Name == null)
                {
                    throw new BadHttpRequestException("This employee name is incorrect");
                }

                var employee = _employeeService.SaveEmployee(employeeRequest);
                return employee;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



    }
}
