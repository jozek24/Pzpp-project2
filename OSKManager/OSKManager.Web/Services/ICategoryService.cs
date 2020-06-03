using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetCategory(Guid id);
        Task<Category> UpdateCategory(Category updatedCategory);
        Task<Category> CreateCategory(Category newCategory);
        Task DeleteCategory(Guid id);
    }
}
