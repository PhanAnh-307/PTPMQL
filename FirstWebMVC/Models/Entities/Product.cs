using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Không được để trống tên sản phẩm")]
    public string? ProductName{ get; set; }

    [Required(ErrorMessage = "Không được để trống giá sản phẩm")]
    public double ProductPrice { get; set; }

    public ICollection<OrderDetail>? OrderDetail { get; set; }
}