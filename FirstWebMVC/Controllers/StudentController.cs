using FirstWebMVC.Data;
using FirstWebMVC.Models.Entities;
using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            var model = await _context.Students
            .Select(s => new StudentViewModel
            {
                StudentCode  = s.StudentCode,
                FullName = s.FullName,
                MaKhoa = s.MaKhoa,
                TenKhoa = s.ThongTinKhoa != null ? s.ThongTinKhoa.TenKhoa : "Không có khoa"
            }).ToListAsync();

            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.DanhSachKhoa = _context.Khoas.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student du_lieu_tu_form)
        {
            if(ModelState.IsValid)
            {
                _context.Students.Add(du_lieu_tu_form);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(du_lieu_tu_form);
        }
    public async Task<IActionResult> Edit(string? id)
    {
        if (id == null) return NotFound();


        var sinh_vien_can_sua = await _context.Students.FindAsync(id);

        if (sinh_vien_can_sua == null) return NotFound();

        ViewBag.DanhSachKhoa = _context.Khoas.ToList();

        return View(sinh_vien_can_sua);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Student du_lieu_moi)
        {
            if(ModelState.IsValid)
            {
                _context.Students.Update(du_lieu_moi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(du_lieu_moi);
        }
 
    public async Task<IActionResult> Delete(int id)
        {
            var sinh_vien = await _context.Students.FindAsync(id);
            if (sinh_vien != null)
            {
                _context.Students.Remove(sinh_vien);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }


    [HttpPost, ActionName("Delete")] 
    public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sinh_vien = await _context.Students.FindAsync(id);
            if (sinh_vien != null)
            {
                // Lệnh xóa thần thánh đây
                _context.Students.Remove(sinh_vien);
            }
            
            await _context.SaveChangesAsync(); 
            return RedirectToAction(nameof(Index));  
        }
    }

}
