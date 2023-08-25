using AutoMapper;
using FullStackDotNetAngular.Models;
using FullStackDotNetAngular.Repositories;
using FullStackDotNetAngular.RequestModels;
using FullStackDotNetAngular.ResponseModel;

namespace FullStackDotNetAngular.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IMapper _mapper;
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(IMapper mapper, ICompanyRepository companyRepository)
        {
            _mapper = mapper;
            _companyRepository = companyRepository;
        }

        public List<CompanyResponseModel> GetCompanies()
        {
            var companies = _companyRepository.GetCompanies();
            return _mapper.Map<List<CompanyResponseModel>>(companies);
        }

        public CompanyResponseModel SaveCompany(CompanyRequestModel companyRequest)
        {
            var company = _mapper.Map<Company>(companyRequest);
            var SaveCompany = _companyRepository.SaveCompany(company);
            return _mapper.Map<CompanyResponseModel>(SaveCompany);
        }
    }
}
