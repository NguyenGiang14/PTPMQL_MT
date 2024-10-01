using Microsoft.EntityFrameworkCore;
using MVCMOVIE.Models;
using MVCMOVIE.Models;
namespace MVCMOVIE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {}
        public DbSet<Person> Person { get; set;}
         public DbSet<Employee> Employees { get; set;}
    }
}