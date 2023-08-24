using Microsoft.AspNetCore.Identity;
using FullStackDotNetAngular.Repositories;
using FullStackDotNetAngular.Services;

namespace FullStackDotNetAngular
{
    public class Resolver
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddScoped<DataContext>();
            

        }
    }
}
