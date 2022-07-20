using Microsoft.EntityFrameworkCore;
namespace PFMBackend.Models
{
    [Keyless]
    public class Category
    {
        public string code { get; set; }
        public string parent_code { get; set; }
        public string name { get; set; } 
    }
}
