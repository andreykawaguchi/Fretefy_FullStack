using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Services;
using Fretefy.Test.Infra.EntityFramework;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;

namespace Fretefy.Test.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<DbContext, TestDbContext>();
            services.AddDbContext<TestDbContext>((provider, options) =>
            {
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });

            ConfigureInfraService(services);
            ConfigureDomainService(services);

            // AutoMapper
            services.AddAutoMapper(typeof(Mapping.AutoMapperProfile));

            // Add CORS policy to allow the Angular dev server to call the API
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAngular", builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            services.AddMvc()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
        }

        private void ConfigureDomainService(IServiceCollection services)
        {
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IRegiaoService, RegiaoService>();
        }

        private void ConfigureInfraService(IServiceCollection services)
        {
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IRegiaoRepository, RegiaoRepository>();
            services.AddScoped<IRegiaoCidadeRepository, RegiaoCidadeRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Enable CORS for requests matching the policy
            app.UseCors("AllowAngular");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
