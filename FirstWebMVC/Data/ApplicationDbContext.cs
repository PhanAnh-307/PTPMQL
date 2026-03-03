using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models.Entities; // Đường dẫn đến các Class của bạn

namespace FirstWebMVC.Data
{
    // Đây là cái "cổng" để dữ liệu đi qua đi lại giữa C# và Database
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Bước 6: Khai báo DbSet (Coi như đây là khai báo các bảng sẽ có trong DB)
        public DbSet<Student> Students { get; set; } 
        public DbSet<Product> Products { get; set; }
    }
}