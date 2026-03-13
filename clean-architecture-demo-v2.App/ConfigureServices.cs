using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace clean_architecture_demo_v2.App
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(ctg =>
            {
                ctg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            return services;
        }
    }
}
