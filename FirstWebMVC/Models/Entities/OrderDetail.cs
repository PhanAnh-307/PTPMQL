using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models.Entities 
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set;}

        public string? OrderId { get; set;}

        [ForeignKey("OrderId")]
        public Order? Order { get; set;}

        public int ProductId { get; set;}

        [ForeignKey("ProductId")]
        public Product? Product { get; set;}

        [Required]
        public int Quantity { get; set;}

        [Required]
        public double Price { get; set;}


    }
}