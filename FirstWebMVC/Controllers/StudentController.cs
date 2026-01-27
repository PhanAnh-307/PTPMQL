namespace FirstWebMVC.Controllers
    
{
    using FirstWebMVC.Models.Entities;
    using Microsoft.AspNetCore.Mvc;

    public class StudentController : Controller
    {
        [HttpPost]
        public IActionResult Index(Student std)
        {
            ViewBag.name = std.FullName;
            ViewBag.code = std.StudentCode;
            return View();
        }
    }
}