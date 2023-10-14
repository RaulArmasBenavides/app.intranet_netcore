using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using app.intranet_netcore.Datos.Data;
using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

namespace app.intranet_netcore
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
           {
              //endpoints.MapAreaControllerRoute("areas", "admin", "{area}/{controller=Usuario}/{action=Index}/{id?}");
              //endpoints.MapAreaControllerRoute("areas", "admin", "{area}/{controller=Alumno}/{action=Index}/{id?}");
           //    //endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

           //    //endpoints.MapControllerRoute(
           //    //    name: "default",
           //    //    pattern: "{controller=Home}/{action=Index}/{id?}");

           //    //endpoints.MapControllerRoute(
           //    // name: "Alumno",
           //    // pattern: "{area:Admin}/{controller=Alumno}/{action=Index}/{id?}"
           //    //);
               endpoints.MapControllerRoute(
                name: "default",
                pattern: "{area=Home}/{controller=Home}/{action=Index}/{id?}");
           });
        }
    }
}
