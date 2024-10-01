using Microsoft.AspNetCore.Mvc;
namespace MVCMOIVE.Controllers;


public class PersonController : Controller
{
    private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext cotext){
            _context = cotext;
        }
   public async Task<IActionResult> Index()
    {
        return View(await _context.Student.TOListAsync());
    }

    [HttpPost]
    public IActionResult Index(string CanCuocCongDan, string HoTen, string QueQuan)
    {
        string strResult = "Xin chao " + HoTen + "-" + QueQuan;
        ViewBag.Info = strResult;
        return View();
    }
}