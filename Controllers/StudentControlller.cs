using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;
public class StudentController: Controller {
    public IActionResult Index(){
        return View();
    }
    [HttpPost]
    public IActionResult Index(Student std){
        
        var data = $"Xin chào: {std.FullName}, đến từ: {std.Address}";
    
        
        ViewData["Data"] = data;
        return View();
    }
}