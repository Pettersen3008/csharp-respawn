using Microsoft.EntityFrameworkCore;
using Respawn.Core.Application.Contracts;
using Respawn.Core.Domain.Models;
using Respawn.Core.Infrastructure.Extensions;

namespace Respawn.Core.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
    
    public async Task<User?> GetUserAsync(string userId)
    {
        return await _context.Users.FindAsync(userId);
    }
    
    public async Task SaveUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
    
    public async Task UpdateUserAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }
    
    public async Task DeleteUserAsync(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}