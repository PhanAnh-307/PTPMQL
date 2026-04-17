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

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBulder)
        {
            base.OnModelCreating(modelBulder);
            modelBulder.Entity<Faculty>().HasData(
                new Faculty { MaKhoa = "CNTT", TenKhoa = "Công nghệ thông tin" },
                new Faculty { MaKhoa = "KETOAN", TenKhoa = "Kế toán" },
                new Faculty { MaKhoa = "QTKD", TenKhoa = "Quản trị kinh doanh" },
                new Faculty { MaKhoa = "CD", TenKhoa = "Cơ điện"}
            );
            modelBulder.Entity<Customer>().HasData(
                new Customer { CustomerId = "KH01", FullName = "Học Viên VIP", Phone = "0999999999" }
            );
            // 2. Nhập kho 2 món hàng
            modelBulder.Entity<Product>().HasData(
                new Product { Id = 1, ProductName = "Sữa Vinamilk", ProductPrice = 10000 },
                new Product { Id = 2, ProductName = "Bánh Mì Ngọt", ProductPrice = 15000 }
            );
            // 3. Đẻ ra 1 cái Đơn Hàng trống rỗng ném cho ông KH01
            modelBulder.Entity<Order>().HasData(
                new Order { OrderId = "DH_MOHANG", OrderDate = new DateTime(2026, 4, 14), CustomerId = "KH01" }
            );
            // 4. In 2 dòng biên lai chi tiết: Ông KH01 mua 2 Sữa, 1 Bánh
            modelBulder.Entity<OrderDetail>().HasData(
                new OrderDetail { Id = 1, OrderId = "DH_MOHANG", ProductId = 1, Quantity = 2, Price = 10000 },
                new OrderDetail { Id = 2, OrderId = "DH_MOHANG", ProductId = 2, Quantity = 1, Price = 15000 }
            );
        }
    }
}