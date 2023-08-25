using FullStackDotNetAngular.Models;
using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;
using FullStackDotNetAngular.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStackDotNetAngular.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("GetCompanies")]
        public List<CompanyResponseModel> GetCompanies()
        {
            try
            {
                var companies = _companyService.GetCompanies();
                return companies;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpPost("SaveCompany")]
        public CompanyResponseModel SaveCompany([FromBody] CompanyRequestModel companyRequest)
        {
            try
            {
                if (companyRequest.CompanyName.Length == 0)
                {
                    throw new BadHttpRequestException("This company name is incorrect");
                }

                var company = _companyService.SaveCompany(companyRequest);
                return company;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
