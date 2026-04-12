using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models.Entities
{
    public class Student
    {
        [Key]

        [Required(ErrorMessage = "Vui lòng nhập mã sinh viên!")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Sai định dạng mã sinh viên")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Mã sinh viên không hợp lệ")]
        public string? StudentCode { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên đầy đủ!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên phải nhỏ hơn 50 ký tự và lớn hơn 3 ký tự")]
        public string? FullName { get; set; }

        public string? MaKhoa { get; set; }
        [ForeignKey("MaKhoa")]
        public Faculty? ThongTinKhoa { get; set; }
    }
}