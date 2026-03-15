using clean_architecture_demo_v2.Domain.Repository;
using clean_architecture_demo_v2.Framing.Data;
using clean_architecture_demo_v2.Framing.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace clean_architecture_demo_v2.Framing
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddFramingServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BlogDbContext") ??
                    throw new InvalidOperationException("Connection string 'BlogDbContext not found'"))
            );

            services.AddTransient<IBlogRepository, BlogRepository>();
            return services;
        }
    }
}
