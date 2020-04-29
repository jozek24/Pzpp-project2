using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
<<<<<<< HEAD
=======
using Microsoft.Extensions.Logging;
using OSKManager.Api.Models;
>>>>>>> Repository
using OSKManager.Model;

namespace OSKManager.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
<<<<<<< HEAD
                options.UseMySql(Configuration.GetConnectionString("sqlConnection"),
                    opts=>opts.MigrationsAssembly("OSKManager.Api")));
=======
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepositoryService<>), typeof(RepositoryService<>));

            services.AddControllers();
>>>>>>> Repository
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
