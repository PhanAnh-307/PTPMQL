using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models.Entities
{
    public class Student
    {
        [Key]
        public int? StudentCode { get; set; }
        public string? FullName { get; set; }
    }
}