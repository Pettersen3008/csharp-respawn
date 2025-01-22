using Microsoft.Extensions.DependencyInjection;
using Respawn.Core.Application.Interfaces;
using Respawn.Core.Application.Services;

namespace Respawn.Core.Application.Extensions;

public static class Configuration
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IUserService, UserService>();
    }
}