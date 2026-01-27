using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Gán dữ liệu vào ViewData để truyền sang View
            ViewData["Message"] = "Hello + Phan Anh + 2021123456"; 
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName)
        {
            ViewBag.Message = "Hello + Phan Anh + 2021123456"; 
            // Gán dữ liệu vào ViewData để truyền sang View
            ViewBag.Name = "Hello" + FullName; 
            return View();
        }
        
    }
}