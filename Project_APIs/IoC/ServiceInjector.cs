using Microsoft.Extensions.DependencyInjection;
using Project_APIs.DAL;
using Project_APIs.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_APIs.IoC
{
    public static class ServiceInjector
    {
        public static IServiceCollection Register(IServiceCollection services)
        {
            services.AddTransient<IProductDAL, ProductDAL>();

            return services;
        }
    }
}
