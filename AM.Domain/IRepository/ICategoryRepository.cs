using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.IRepository
{
    public interface ICategoryRepository
    {
        public Task<IQueryable<Entities.Category.Category>> GetCategories();

        public Task<Entities.Category.Category> GetCategoryById(string categoryId);

        public Task InsertCategory(Entities.Category.Category category);

        public Task UpdateCategory(Entities.Category.Category category);

        public Task DeleteCategory(Entities.Category.Category category);
    }
}
