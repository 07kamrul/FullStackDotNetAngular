using FullStackDotNetAngular.Models;

namespace FullStackDotNetAngular.Repositories
{
    public interface ICompanyRepository
    {
        List<Company> GetCompanies();
        Company SaveCompany(Company company);
    }
}
