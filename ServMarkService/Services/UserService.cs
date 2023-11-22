using Microsoft.EntityFrameworkCore;
using ServMarkService.Data;
using ServMarkService.Models;

namespace ServMarkService.Services;

public class UserService : IUserService
{
    private readonly UsersContext _context;
    
    public UserService(UsersContext context)
    {
        _context = context;
    }
    
    public IEnumerable<User> Get()
    {
        return _context.Users.ToList();
    }
    
    public async Task Add(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
    
    public async Task<User?> GetByEmail(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email) ?? null;
    }
}

public interface IUserService
{
    IEnumerable<User> Get();
    Task Add(User user);
    Task<User?> GetByEmail(string email);
}