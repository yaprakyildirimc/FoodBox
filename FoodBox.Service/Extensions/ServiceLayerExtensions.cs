using FoodBox.Service.Services.Abstract;
using FoodBox.Service.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FoodBox.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IProductService, ProductService>();

            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
