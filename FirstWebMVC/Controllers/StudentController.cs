using FirstWebMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

namespace FirstWebMVC.Controllers
{
    public class StudentController : Controller
    {
       private readonly ApplicationDbContext _context;

       public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public async Task<IActionResult> Index()
        {
            var model = await _context.Students.ToListAsync();

            return View(model);
        }
    }
}