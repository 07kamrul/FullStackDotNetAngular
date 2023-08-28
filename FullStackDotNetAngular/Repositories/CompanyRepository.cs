using FullStackDotNetAngular.Models;
using Microsoft.EntityFrameworkCore;

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
            return _context.Companys.AsNoTracking().ToList();
        }

        public Company SaveCompany(Company company)
        {
            _context.Companys.Add(company);
            _context.SaveChanges();
            return company;
        }
    }
}
