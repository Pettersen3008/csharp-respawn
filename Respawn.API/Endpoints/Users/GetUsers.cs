using Microsoft.AspNetCore.Mvc;
using Respawn.Core.Application.Interfaces;

namespace Respawn.API.Endpoints.Users;

public static class GetUsers
{
    
    public static void MapGetUsers(this WebApplication app)
    {
        app.MapGet("/users", async ([FromServices] IUserService userService) =>
        {
            var users = await userService.GetUsersAsync();
            return Results.Json(users);
        });
    }
}