using Microsoft.EntityFrameworkCore;
using FullStackDotNetAngular.Models;
using Microsoft.Extensions.Options;

namespace FullStackDotNetAngular.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Company> Companys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(s => s.EmpCode); ;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the DbContext to log sensitive data
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
