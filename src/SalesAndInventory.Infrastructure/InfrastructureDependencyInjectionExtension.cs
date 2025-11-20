using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesAndInventory.Domain.Repositories;
using SalesAndInventory.Domain.Repositories.User;
using SalesAndInventory.Domain.Security.Cryptography;
using SalesAndInventory.Domain.Security.Token;
using SalesAndInventory.Infrastructure.DataAcess;
using SalesAndInventory.Infrastructure.DataAcess.Repositories.User;
using SalesAndInventory.Infrastructure.Security.Cryptography;
using SalesAndInventory.Infrastructure.Security.Token;

namespace SalesAndInventory.Infrastructure;


public static class InfrastructureDependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {   
        AddRepositories(services);
        AddDbContext(services, configuration);
        AddToken(services,configuration);
        services.AddScoped<IEncrypter, Bcrypt>();
    }

    public static void AddToken(this IServiceCollection services, IConfiguration configuration)
    {
        var expirationTimeMinutes = configuration.GetValue<uint>("Settings:Jwt:ExpiresMinutes");
        var singingKey = configuration.GetValue<string>("Settings:Jwt:SigningKey");
        services.AddScoped<IAccessTokenGenerator>(c => new JwtTokenGenerator(expirationTimeMinutes, singingKey!));
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IUnityOfWork, UnityOfWork>();
        services.AddScoped<IUserRepositoryWriteOnly, UserRepository>();
        services.AddScoped<IUserRepositoryReadOnly, UserRepository>();
    }

    private static void AddDbContext(IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<SalesAndInventoryContext>(config => config.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }

}
