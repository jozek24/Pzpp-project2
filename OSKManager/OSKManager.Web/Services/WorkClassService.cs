using Microsoft.AspNetCore.Components;
using OSKManager.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public class WorkClassService : IWorkClassService
    {
        private readonly HttpClient httpClient;

        public WorkClassService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WorkClass> CreateWorkClass(WorkClass newWorkClass)
        {
            return await httpClient.PostJsonAsync<WorkClass>("api/workclasses", newWorkClass);
        }

        public async Task DeleteWorkClass(Guid id)
        {
            await httpClient.DeleteAsync($"api/workclasses/{id}");
        }

        public async Task<WorkClass> GetWorkClass(Guid id)
        {
            return await httpClient.GetJsonAsync<WorkClass>($"api/workclasses/{id}");
        }

        public async Task<IEnumerable<WorkClass>> GetWorkClasses()
        {
            return await httpClient.GetJsonAsync<WorkClass[]>("api/workclasses");
        }

        public async Task<WorkClass> UpdateWorkClass(WorkClass updatedWorkClass)
        {
            return await httpClient.PutJsonAsync<WorkClass>("api/workclasses", updatedWorkClass);
        }
    }
}
