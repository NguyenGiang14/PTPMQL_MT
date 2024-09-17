using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mvcmovie.Models;

namespace MVCMOVIE.Controllers;

public class HomeController : Controller
{

  public IActionResult Demo()
  {
    return View();
  }
  [HttpPost]
  public IActionResult Demo (string FullName)
  {
    string strResult ="Hello" + FullName ;
    ViewBag.thongbao = strResult;
    return View();
  }
   
}
