using Microsoft.AspNetCore.Mvc;
using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;
using FullStackDotNetAngular.Services;
using System.Net;

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

        [HttpGet("GetEmployee/{empCode}")]
        public EmployeeResponseModel GetEmployee(int empCode)
        {
            try
            {
                var employee = _employeeService.GetEmployee(empCode);
                return employee;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpPost("SaveEmployee")]
        public EmployeeResponseModel SaveEmployee([FromBody] EmployeeRequestModel employeeRequest)
        {
            try
            {
                if (employeeRequest.Name.Length == 0)
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


        [HttpPut("ApproveEmployee")]
        public ActionResult UpdateAccount([FromBody] EmployeeRequestModel employeeRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new BadHttpRequestException("Invalid request.");
                }

                _employeeService.UpdateEmployee(employeeRequest);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("RejectEmployee/{id}")]
        public IActionResult RejectEmployee(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            try
            {
                _employeeService.RejectEmployee(id);
                return Ok("This employee is rejected.");
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, (int)HttpStatusCode.InternalServerError);
            }
        }

    }
}
