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
        public DbSet<Student> Students {get; set;}
        public DbSet<Faculty> Khoas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBulder)
        {
            base.OnModelCreating(modelBulder);
            modelBulder.Entity<Faculty>().HasData(
                new Faculty { MaKhoa = "CNTT", TenKhoa = "Công nghệ thông tin" },
                new Faculty { MaKhoa = "KETOAN", TenKhoa = "Kế toán" },
                new Faculty { MaKhoa = "QTKD", TenKhoa = "Quản trị kinh doanh" },
                new Faculty { MaKhoa = "CD", TenKhoa = "Cơ điện"}
            );
        }
    }
}