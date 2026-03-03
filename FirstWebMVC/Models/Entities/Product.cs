using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }
    public int ProductName{ get; set; }
}