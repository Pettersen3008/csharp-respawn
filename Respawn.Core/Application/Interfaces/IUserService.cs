using Respawn.Core.Domain.Models;

namespace Respawn.Core.Application.Interfaces;

public interface IUserService
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User?> GetUserAsync(string userId);
    Task SaveUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(User user);
}