using AutoMapper;
using PFMBackend.Data.Entities;
using PFMBackend.Models;
using PFMBackend.Data.Repositories;
using PFMBackend.Commands;

namespace PFMBackend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task<Category> CreateCategory(CreateCategoryCommand category)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryList> GetCategories(string parentCode)
        {
            return await _categoryRepository.GetCategories(parentCode);
        }

        public async Task ImportCategories(CreateCategoryList categories)
        {
            await _categoryRepository.ImportCategories(categories);
        }

    }
}



