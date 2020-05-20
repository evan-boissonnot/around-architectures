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
using Around.Architectures.Core.Interfaces.Data.Businesses;
using Around.Architectures.Core.Models;
using Around.Architectures.Core.Interfaces.UI.Presentations;

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
                });
            });

            services.AddScoped<IOrderDataLayer, OrderDal>();
            services.AddScoped<IBusinessOf<Order>, OrderBusiness>();
            services.AddScoped<IPresentation<Order>, OrderPresentation>();

            return services;
        }
    }
}
