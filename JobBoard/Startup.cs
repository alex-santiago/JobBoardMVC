using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using JobBoard.Data;
using JobBoard.Models;

namespace JobBoard
{
    public class Startup
    {
        IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // Entity Framework class that implements the IJobPostRepository interface
            services.AddTransient<IJobPostRepository, EFJobPostRepository>();

            // call to the fake repository for initial tests
            //services.AddTransient<IJobPostRepository, FakeJobPostRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {

                routes.MapRoute(
                    name: "pagination",
                    template: "JobPosts/Page{page}",
                    defaults: new { Controller = "JobPost", action = "List"});

                routes.MapRoute(
                    name: "homepage",
                    template: "JobPost/{action}",
                    defaults: new { Controller = "JobPost", action = "List" });

                // TODO: Replace with RegExp
                routes.MapRoute(
                    name: "homepage2",
                    template: "JobPosts/{action}",
                    defaults: new { Controller = "JobPost", action = "List" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
