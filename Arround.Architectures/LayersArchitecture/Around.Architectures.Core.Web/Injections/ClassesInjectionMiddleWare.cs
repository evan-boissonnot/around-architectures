using Around.Architectures.Core.Businesses;
using Around.Architectures.Core.Dals;
using Around.Architectures.Core.Data;
using Around.Architectures.Core.Interfaces.Businesses;
using Around.Architectures.Core.Interfaces.Data.Dals;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ClassesInjectionMiddleWare
    {
        public static IServiceCollection AddApplicationInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DefaultContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultDbContext"));
            });

            services.AddTransient<IOrderDataLayer, OrderDal>();
            services.AddTransient<IOrderBusiness, OrderBusiness>();

            return services;
        }
    }
}
