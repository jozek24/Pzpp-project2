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

        public Task<DrivingDate> CreateDrivingDate(DrivingDate newDrivingDate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDrivingDate(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<DrivingDate> GetDrivingDate(Guid id)
        {
            throw new NotImplementedException();
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
