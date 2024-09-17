using Microsoft.EntityFrameworkCore;
using MVCMOIVE.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;
namespace MVCMOVIE.Data
{
    public  class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {}
    public DbSet<Employee> Emplyoyee { get; set;}
}
}