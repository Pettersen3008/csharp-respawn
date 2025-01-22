using Microsoft.EntityFrameworkCore;
using Respawn.Core.Infrastructure.Extensions;
using Scalar.AspNetCore;

namespace Respawn.API.Extensions;

public static class Configuration
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql("Host=localhost;Database=respawn;Username=respawn;Password=respawn"));
        services.AddControllers();
        services.AddOpenApi();
        services.AddEndpointsApiExplorer();
        
        Core.Infrastructure.Extensions.Configuration.RegisterServices(services);
        Core.Application.Extensions.Configuration.RegisterServices(services);
    }
    
    public static void RegisterApps(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference();
            app.UseDeveloperExceptionPage();
        }
        
        app.UseHttpsRedirection();
        app.MapControllers();
    }
}