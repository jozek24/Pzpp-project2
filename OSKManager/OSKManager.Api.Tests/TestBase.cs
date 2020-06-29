using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace OSKManager.Api.Tests
{
    public abstract class TestBase
    {
        protected readonly TestServer _server;
        protected readonly HttpClient _client;
        protected TestBase()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }
    }
}
