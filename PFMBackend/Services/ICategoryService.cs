using PFMBackend.Data.Entities;
using PFMBackend.Models;
using PFMBackend.Commands;

namespace PFMBackend.Services
{
    public interface ICategoryService
    {

        Task<Category> CreateCategory(CreateCategoryCommand category);
        Task ImportCategories(CreateCategoryList categories);
        Task<CategoryList> GetCategories(string parent_code);

    }
}


