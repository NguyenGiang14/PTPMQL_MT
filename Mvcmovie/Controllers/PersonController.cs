using Microsoft.AspNetCore.Mvc;
using MVCMOIVE.Models;
namespace MVCMOVIE.Controllers
{
public class PersonController : Controller
{
public IActionResult Index ()
{
    return View();
}
[HttpPost]
      public IActionResult Index( Person ps )
{
        string  strResult ="Xin chao" + ps.PersonID + "-" + ps.FullName +"-" + ps.Address;
        ViewBag.ifPerson= strResult;
        return View();
}
}
}