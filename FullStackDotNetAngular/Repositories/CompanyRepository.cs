using FullStackDotNetAngular.Models;

namespace FullStackDotNetAngular.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext _context;
        public CompanyRepository(DataContext context)
        {
            _context = context;
        }

        public List<Company> GetCompanies()
        {
            return _context.Company.ToList();
        }

        public Company SaveCompany(Company company)
        {
            _context.Company.Add(company);
            _context.SaveChanges();
            return company;
        }
    }
}
