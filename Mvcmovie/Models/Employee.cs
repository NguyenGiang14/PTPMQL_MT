using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace  MVCMOIVE.Models
{
   [Table("Employee")]
    public class Employee{
        [Key]
    public string?  StudentID { get; set; }
    public string? FullName { get; set; }
    public string? Address { get; set; }
    }
}
