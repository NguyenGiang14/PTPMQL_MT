using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace  MVCMOIVE.Models
{
    public class Person{
    public string?  PersonID { get; set; }
    public string? FullName { get; set; }
    public string? Address { get; set; }
    }
}
