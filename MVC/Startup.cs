using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC.Middlewares;
using MVC.Services;
using MVC.Services.Abstract;

namespace MVC
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
            services.AddControllersWithViews();
            services.AddSingleton<ICounterService, CounterService>();  

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
          //  app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMiddleware<CounterMiddleware>();
            app.UseRouting();

            //  app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapAreaControllerRoute(
                //    name: "adminArea",
                //    areaName:"admin",
                //    pattern: "admin/{controller=Settings}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(
                    name: "myArea",
                    areaName: "my",
                    pattern: "my/{controller=Counter}/{action=Index2}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
