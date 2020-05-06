using OSKManager.Api.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient httpClient;

        public AccountService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<UserRegistrationModel> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<UserRegistrationModel> Register(UserRegistrationModel userModel)
        {
            return await httpClient.GetJsonAsync<UserRegistrationModel>($"api/employees/{userModel}");
        }
    }
}
