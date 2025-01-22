using Respawn.Core.Application.Contracts;
using Respawn.Core.Application.Interfaces;
using Respawn.Core.Domain.Models;

namespace Respawn.Core.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _userRepository.GetUsersAsync();
    }
    
    public async Task<User?> GetUserAsync(string userId)
    {
        return await _userRepository.GetUserAsync(userId);
    }
    
    public async Task SaveUserAsync(User user)
    {
        await _userRepository.SaveUserAsync(user);
    }
    
    public async Task UpdateUserAsync(User user)
    {
        await _userRepository.UpdateUserAsync(user);
    }
    
    public async Task DeleteUserAsync(User user)
    {
        await _userRepository.DeleteUserAsync(user);
    }
}