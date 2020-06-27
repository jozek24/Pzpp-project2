using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Api.Tests
{
	public class WebApiTesterFactory : WebApplicationFactory<TestStartup>
	{
		protected override IWebHostBuilder CreateWebHostBuilder()
		{
			return WebHost.CreateDefaultBuilder()
				.UseStartup<TestStartup>();
		}

		protected override void ConfigureWebHost(IWebHostBuilder builder)
		{
			builder.UseContentRoot(".");
			base.ConfigureWebHost(builder);
		}
	}
}
