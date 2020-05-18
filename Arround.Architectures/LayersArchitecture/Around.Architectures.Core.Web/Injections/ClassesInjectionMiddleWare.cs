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
using Around.Architectures.Core.Web.Presentation;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ClassesInjectionMiddleWare
    {
        public static IServiceCollection AddApplicationInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DefaultContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultDbContext"), sqlOptions =>
                {
                    sqlOptions.UseRowNumberForPaging(true);
                });
            });

            services.AddScoped<IOrderDataLayer, OrderDal>();
            services.AddScoped<IOrderBusiness, OrderBusiness>();
            services.AddScoped<OrderPresentation, OrderPresentation>();

            return services;
        }
    }
}
