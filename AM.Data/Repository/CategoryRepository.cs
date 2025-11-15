using AM.Data.Context;
using AM.Domain.Entities.Category;
using AM.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AM.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AMContext _context;

        public CategoryRepository(AMContext context)
        {
            _context = context;
        }

        public async Task DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
        }

        public async Task<IQueryable<Category>> GetCategories()
        {
            return _context.Categories;
        }

        public async Task<Category> GetCategoryById(string categoryId)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == categoryId);
        }

        public Task InsertCategory(Category category)
        {
            return _context.Categories.AddAsync(category).AsTask();
        }

        public async Task UpdateCategory(Category category)
        {
            _context.Update(category);
        }
    }
}
