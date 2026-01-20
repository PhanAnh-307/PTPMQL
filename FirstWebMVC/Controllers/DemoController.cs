using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            // Gán dữ liệu vào ViewData để truyền sang View
            ViewData["Message"] = "Hello + Phan Anh + 2021123456"; 
            return View();
        }
    }
}