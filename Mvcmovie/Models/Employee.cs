using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace  MVCMOIVE.Models.Person
{
    public class Person : Employee{
    public string?  Tuoi { get; set; }
    public string? GioiTinh { get; set; }
    }
}