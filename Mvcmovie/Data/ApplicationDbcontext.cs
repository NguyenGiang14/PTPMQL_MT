using Microsoft.EntityFrameworkCore;
using MVCMOIVE.Models;
using Mvcmovie.Models;
namespace MVCMOVIE.Data;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {}
        public DbSet<Person> Person { get; set; }
         public DbSet<Employee> Employee { get; set;}
    }
