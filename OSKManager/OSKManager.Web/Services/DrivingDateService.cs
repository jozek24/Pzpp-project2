using Microsoft.AspNetCore.Components;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public class DrivingDateService : IDrivingDateService
    {
        private readonly HttpClient httpClient;

        public DrivingDateService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<DrivingDate> CreateDrivingDate(DrivingDate newDrivingDate)
        {
            return await httpClient.PostJsonAsync<DrivingDate>("api/drivingdates", newDrivingDate);
        }

        public async Task DeleteDrivingDate(Guid id)
        {
            await httpClient.DeleteAsync($"api/drivingdates/{id}");
        }

        public async Task<DrivingDate> GetDrivingDate(Guid id)
        {
            return await httpClient.GetJsonAsync<DrivingDate>($"api/drivingdates/{id}");
        }

        public Task<IEnumerable<DrivingDate>> GetDrivingDates()
        {
            throw new NotImplementedException();
        }

        public Task<DrivingDate> UpdatDrivingDate(DrivingDate updatedDrivingDate)
        {
            throw new NotImplementedException();
        }
    }
}
