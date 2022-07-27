using System.ComponentModel.DataAnnotations;

namespace PFMBackend.Commands
{
    public class CreateCategoryCommand
    {
        [Required]
        public string code { get; set; }

        [Required]
        public string name { get; set; }

        public string parent_code { get; set; }
    }
}



