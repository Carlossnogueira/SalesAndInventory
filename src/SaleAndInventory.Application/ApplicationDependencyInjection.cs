using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaleAndInventory.Application.AutoMapper;
using SaleAndInventory.Application.UseCase.User;
using SaleAndInventory.Application.UseCase.User.Register;

namespace SaleAndInventory.Application;

public static class ApplicationDependencyInjection
{
    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        AddAutoMapper(services);
        AddUseCase(services);
    }
    
    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCase(IServiceCollection services)
    {
        services.AddScoped<IRegisterUserUseCase,RegisterUserUseCase>();
    }
}