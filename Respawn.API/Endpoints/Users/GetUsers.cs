using Respawn.Core.Domain.Models;

namespace Respawn.API.Endpoints.Users;

public static class GetUsers
{
    
    public static void MapGetUsers(this WebApplication app)
    {
        app.MapGet("/users", async () =>
        {
            // var users = await userRepository.GetUsersAsync();
            var res = new List<User>
            {
                new User { Id = 1, Name = "User 1" },
                new User { Id = 2, Name = "User 2" },
                new User { Id = 3, Name = "User 3" }
            };
            return Results.Json(res);
        });
    }
}