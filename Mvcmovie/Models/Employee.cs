using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mvcmovie.Models;
namespace  MVCMOIVE.Models;

    public class Employee : Person {
    public string?  Tuoi { get; set; }
    public string? GioiTinh { get; set; }
    }
