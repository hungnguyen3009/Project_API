using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project_APIs.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_APIs.IoC
{
    public static class MariaDbInjector
    {
        public static IServiceCollection Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<MariaDbConfiguration>(_ => new MariaDbConfiguration(configuration["ConnectionStrings:MariaDb_ConnectionString"]));

            return services;
        }
    }
}
