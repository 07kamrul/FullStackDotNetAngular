using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;

namespace FullStackDotNetAngular.Services
{
    public interface ICompanyService
    {
        List<CompanyResponseModel> GetCompanies();
        CompanyResponseModel SaveCompany(CompanyRequestModel companyRequest);
    }
}
