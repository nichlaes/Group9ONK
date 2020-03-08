using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delopgaveprojekt.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Delopgaveprojekt.DbFactory;
using Delopgaveprojekt.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace Delopgaveprojekt
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
            var host = Configuration["DBHOST"] ?? "localhost";
            var port = Configuration["DBPORT"] ?? "3306";
            var paasword = Configuration["DBPASSWORD"] ?? "secret";

            services.AddDbContext<AppDbContext.AppDbContext>(options =>
                {
                    //options.UseMySql($"server={host}; userid=root; pwd={paasword};" + $"port={port}; database=haandvaerkers");
                    options.UseInMemoryDatabase("haandvaerkers");
                }
            );
            //services.AddSingleton<AppDbContext.AppDbContext>();
            services.AddControllers();
            //services.AddScoped<IDbFactory, DbFactory.DbFactory>();
            services.AddScoped<IHaandvaerkerRepository, HaandvaerkerRepository>();
            //services.AddScoped<IVaerktoejRepository, VaerktoejRepository>();
            //services.AddScoped<IVaerktoejskasseRepository, VaerktoejskasseRepository>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, Delopgaveprojekt.AppDbContext.AppDbContext context)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //context.Database.Migrate();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
