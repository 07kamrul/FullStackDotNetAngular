using FullStackDotNetAngular.Models;
using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;
using FullStackDotNetAngular.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStackDotNetAngular.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetDepartments")]
        public List<DepartmentResponseModel> GetDepartments()
        {
            try
            {
                var departments = _departmentService.GetDepartments();
                return departments;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpPost("SaveDepartment")]
        public DepartmentResponseModel SaveDepartment([FromBody] DepartmentRequestModel departmentRequest)
        {
            try
            {
                if (departmentRequest.DepartmentName.Length == 0)
                {
                    throw new BadHttpRequestException("This department name is incorrect");
                }

                var department = _departmentService.SaveDepartment(departmentRequest);
                return department;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
