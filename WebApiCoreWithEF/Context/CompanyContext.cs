
namespace WebApiCoreWithEF.Context
{
    using Microsoft.EntityFrameworkCore;
    using WebApiCoreWithEF.Models;

    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
