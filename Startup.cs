using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using MoviesAPI.Services;

namespace MoviesAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "Server=192.168.99.100;Database=MoviesDB;User Id=sa;Password=MyNewPass2019*_";
                services.AddDbContext<MoviesDbContext2>(o => o.UseSqlServer(connectionString));
                //services.AddControllers();
                services.AddControllersWithViews();
                //services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MoviesDbContext2 moviesDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
				{
					HotModuleReplacement = true
				});
            }
            app.UseStaticFiles();
            app.UseRouting();
            //app.UseCors();
            moviesDbContext.CreateSeedData();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    //pattern: "{controller=Movies}/{action=GetMovies}");
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
