using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models.Entities
{
    public class Order
    {
        [Key]
        public string? OrderId { get; set;}
        [Required(ErrorMessage = "Phải có ngày lập hóa đơn")]
        public DateTime OrderDate { get; set;}
        
        public string? CustomerId { get; set;}

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set;}

        public ICollection<OrderDetail> OrderDetail { get; set;}


    }
}