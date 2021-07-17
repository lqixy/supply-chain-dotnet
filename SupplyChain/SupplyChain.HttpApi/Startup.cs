using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SupplyChain.Product.Application;
using SupplyChain.Product.EntityFrameworkCore;
using SupplyChain.StockIn.Application;
using SupplyChain.StockIn.EntityFrameworkCore;

namespace SupplyChain.HttpApi
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

            services.AddCustomEfDbContext(Configuration);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SupplyChain.HttpApi", Version = "v1" });
            });

            //var config = new MapperConfiguration(configure =>
            //{
            //    configure.AddMaps(System.AppDomain.CurrentDomain.GetAssemblies());
            //});
            //config.CreateMapper();

        }

        public void ConfigureContainer(ContainerBuilder container)
        {
            container.RegisterModule(new SupplyChainProductApplicationAutofacModule());
            container.RegisterModule(new SupplyChainProductEntityFrameworkCoreAutofacModule());
            container.RegisterModule(new SupplyChainStockInApplicationAutofacModule());
            container.RegisterModule(new SupplyChainStockInEntityFrameworkCoreAutofacModule());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SupplyChain.HttpApi v1"));
            }

            //app.ApplicationServices.GetAutofacRoot();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }

    static class CustomExtensionsMethods
    {
        public static IServiceCollection AddCustomEfDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddProductDbContext(configuration)
                .AddStockInDbContext(configuration);
            return services;
        }

        public static IServiceCollection AddProductDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductEfDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Product"));
            });
            return services;
        }

        public static IServiceCollection AddStockInDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StockInEfDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Product"));
            });
            return services;
        }

    }
}
