using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models.Entities
{
    public class Faculty
    {
        [Key]
        [Required(ErrorMessage = "Không được để trống mã khóa!")]
        public string? MaKhoa { get; set; }

        [Required(ErrorMessage = "Không được để trống tên khóa!")]
        public string? TenKhoa { get; set; }

        public ICollection<Student>? DanhSachSinhVien { get; set; }
    }
}