using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public class DrivingDateService
    {
        private readonly HttpClient httpClient;

        public DrivingDateService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
