using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesAndInventory.Domain.Repositories;
using SalesAndInventory.Infrastructure.DataAcess;

namespace SalesAndInventory.Infrastructure;


public static class InfrastructureDependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddRepositories(services);
        AddDbContext(services, configuration);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IUnityOfWork, UnityOfWork>();
    }

    private static void AddDbContext(IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<SalesAndInventoryContext>(config => config.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }

}
