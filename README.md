# PTPMQL

## Cấu trúc cấu hình dự án .NET MVC

### 1. Dự án sử dụng hệ thống cấu hình linh hoạt của .NET Core, bao gồm:
1. **appsettings.json**: Lưu trữ cấu hình ứng dụng, ví dụ như    (Connection String, Logging).
2. **Properties/launchSettings.json**: Cấu hình môi trường local để test ứng dụng, chạy thử trên local (Port).
3. **Program.cs**: Đăng ký các dịch vụ hệ thống, cách hệ thống vận hành, khi chạy ứng dụng web thì nó kiểm tra program.cs đầu 
tiên để biết cách ứng dụng vận hành(Middleware).
4. **wwwroot/**: Quản lý tài nguyên tĩnh cho giao diện (CSS, JS, Images).

### 2. Định tuyến (Routing)
- Là cơ chế điều hướng yêu cầu từ URL đến đúng Controller và Action tương ứng.
- Cấu hình mặc định: `{controller}/{action}/{id}`.

### 3. Namespace
- Là cách phân loại và tổ chức các lớp (class) để tránh trùng tên trong dự án lớn.
- Giúp quản lý code sạch sẽ và tường minh hơn.

### 4. Controller & View
- **Controller**: Nhận yêu cầu, xử lý nghiệp vụ và điều phối dữ liệu.
- **View**: Sử dụng công nghệ Razor để hiển thị dữ liệu từ Controller dưới dạng giao diện người dùng (HTML).