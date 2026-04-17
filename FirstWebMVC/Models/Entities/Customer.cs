using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models.Entities
{
    public class Customer
    {
        [Key]
        public string? CustomerId { get; set; }

        [Required(ErrorMessage= "Không được để trống mục này!")]
        [StringLength(50, MinimumLength=3, ErrorMessage="Tên phải nhỏ hơn 50 ký tự và lớn hơn 3 ký tự")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Không được để trống mục này")]
        [RegularExpression("^[0-9]{10}$")]

        public string? Phone { get; set;}
        public ICollection<Order>? Orders { get; set;}
    }
}