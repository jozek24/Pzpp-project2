using Blazored.LocalStorage;
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
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public CategoryService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
           _localStorageService = localStorageService;
        }

        public async Task<Category> CreateCategory(Category newCategory)
        {
            return await _httpClient.PostJsonAsync<Category>("api/category", newCategory);
        }

        public async Task DeleteCategory(Guid id)
        {
            await _httpClient.DeleteAsync($"api/category/{id}");
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _httpClient.GetJsonAsync<Category[]>($"api/category");
        }

        public async Task<Category> GetCategory(Guid id)
        {
         //   var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/categories/{id}");
            return await _httpClient.GetJsonAsync<Category>($"api/categories/{id}", );
        }

        public async Task<Category> UpdateCategory(Category updatedCategory)
        {
            return await _httpClient.PutJsonAsync<Category>("api/categories", updatedCategory);
        }
    }
}
