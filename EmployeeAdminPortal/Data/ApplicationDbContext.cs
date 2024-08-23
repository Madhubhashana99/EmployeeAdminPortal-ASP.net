using EmployeeAdminPortal.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Create a constructor
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //Create a property
        public DbSet<Employee> Employees { get; set; }
    }
}
