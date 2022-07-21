using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PFMBackend.Models
{
    
    public class Category
    {
        [Key]
        public string? code { get; set; }
        [Required]
        public string? parent_code { get; set; }
        [Required]
        public string? name { get; set; } 
    }
}
