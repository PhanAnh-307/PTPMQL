using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;
public class StudentController: Controller {
    public IActionResult Index(){

        List<string> majors = new List<string>{
            "CNTT",
            "Du lịch",
            "QTKD",
            "Thú Y"
        };
        ViewBag.Majors = majors;

        return View();
    }
    [HttpPost]
    public IActionResult Index(Student std){
        
        var data = $"Xin chào: {std.FullName}, sinh ngày {std.Birthday},đến từ: {std.Address}";
    
        
        TempData["Data"] = data;
        return RedirectToAction("Index");
    }
}