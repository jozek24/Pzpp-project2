using Microsoft.AspNetCore.Components;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace OSKManager.Web.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Category> CreateCategory(Category newCategory)
        {
            return await httpClient.PostJsonAsync<Category>("api/categories", newCategory);
        }

        public async Task DeleteCategory(Guid id)
        {
            await httpClient.DeleteAsync($"api/categories/{id}");
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await httpClient.GetJsonAsync<Category[]>($"api/categories");
        }

        public async Task<Category> GetCategory(Guid id)
        {
            return await httpClient.GetJsonAsync<Category>($"api/categories/{id}");
        }

        public async Task<Category> UpdateCategory(Category updatedCategory)
        {
            return await httpClient.PutJsonAsync<Category>("api/categories", updatedCategory);
        }
    }
}
