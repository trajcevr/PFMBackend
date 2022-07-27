using PFMBackend.Commands;

namespace PFMBackend.Data.Entities
{
    public class CreateCategoryList
    {
        public List<CreateCategoryCommand> Categories { get; set; } = new List<CreateCategoryCommand>();
    }
}


