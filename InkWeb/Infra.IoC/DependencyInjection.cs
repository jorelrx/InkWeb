using Application.Mappings;
using Application.Services;
using Application.Services.Interfaces;
using Domain.Repositories;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InkWebDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("InkWebConnection")));
            services.AddScoped<ITattooRepository, TattooRepository>();
            services.AddScoped<ISchedulingRepository, SchedulingRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(DomainToDtoMapping));

            services.AddScoped<ITattooService, TattooService>();
            services.AddScoped<ISchedulingService, SchedulingService>();

            return services;
        }
    }
}
