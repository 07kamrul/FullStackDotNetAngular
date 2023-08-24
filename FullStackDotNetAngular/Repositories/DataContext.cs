using Microsoft.EntityFrameworkCore;
using FullStackDotNetAngular.Models;

namespace FullStackDotNetAngular.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(s => s.EmpCode); ;
        }
    }
}
