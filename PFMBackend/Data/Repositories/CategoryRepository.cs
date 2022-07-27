using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PFMBackend.Data.Entities;
using PFMBackend.Models;



namespace PFMBackend.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PFMDbContex _context;
        private readonly IMapper _mapper;

        public CategoryRepository(PFMDbContex context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CategoryList> GetCategories(string parentCode)
        {
            var query = _context.Categories.AsQueryable();

            if (!string.IsNullOrEmpty(parentCode))
            {
                query = query.Where(x => x.parent_code == parentCode);
            }

            var allCat = await query.ToListAsync();
            return new CategoryList
            {
                CatList = _mapper.Map<List<Category>>(allCat)
            };
        }

        public async Task ImportCategories(CreateCategoryList categories)
        {
            foreach (var cat in categories.Categories)
            {
                var categoryEntity = await _context.Categories.FindAsync(cat.code);

                if (categoryEntity != null)
                {
                    categoryEntity.parent_code = cat.parent_code;
                    categoryEntity.name = cat.name;

                    _context.Entry(categoryEntity).State = EntityState.Modified;
                }
                else
                {
                    await _context.AddAsync(_mapper.Map<CategoryEntity>(cat));
                }

                await _context.SaveChangesAsync();
            }
        }
    }
}

