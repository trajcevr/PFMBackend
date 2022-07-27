using PFMBackend.Data.Entities;
using PFMBackend.Commands;
using PFMBackend.Models;



namespace PFMBackend.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task ImportCategories(CreateCategoryList categories);

        Task<CategoryList> GetCategories(string parent_code);
        
    }
}

