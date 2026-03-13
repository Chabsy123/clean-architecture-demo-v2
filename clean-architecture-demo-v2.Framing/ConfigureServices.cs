using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture_demo_v2.Framing
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddFramingServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
