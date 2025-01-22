using Microsoft.EntityFrameworkCore;
using Respawn.Core.Infrastructure.Extensions;

namespace Respawn.API.Extensions;

public static class Configuration
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql("Host=localhost;Database=respawn;Username=respawn;Password=respawn"));
        services.AddAuthentication();
        services.AddAuthorization();
        services.AddControllers();
        services.AddOpenApi();
        services.AddEndpointsApiExplorer();
        
    }
    
    public static void RegisterApps(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }
        
        app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();
    }
}