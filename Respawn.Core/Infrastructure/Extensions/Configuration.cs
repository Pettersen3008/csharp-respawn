using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Respawn.Core.Application.Contracts;
using Respawn.Core.Infrastructure.Repositories;

namespace Respawn.Core.Infrastructure.Extensions;

public static class Configuration
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>  options.UseNpgsql("Host=localhost;Database=respawn;Username=respawn;Password=respawn"));
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}