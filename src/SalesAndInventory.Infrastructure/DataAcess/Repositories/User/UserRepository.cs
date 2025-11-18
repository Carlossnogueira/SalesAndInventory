using Microsoft.EntityFrameworkCore;
using SalesAndInventory.Domain.Repositories.User;
namespace SalesAndInventory.Infrastructure.DataAcess.Repositories.User;


public class UserRepository : IUserRepositoryReadOnly, IUserRepositoryWriteOnly
{
    private readonly SalesAndInventoryContext _context;
    
    public UserRepository(SalesAndInventoryContext context)
    {
        _context = context;
    }

    // read 
    
    public async Task<Domain.Entities.User?> GetUserAsync(long userId)
    {
        var result = await _context.Users.FindAsync(userId);
        return result;
    }

    public async Task<bool> UserExistsWithSameLogin(string login)
    {
        var result = await _context.Users.AnyAsync(u => u.Login == login);
        return result;
    }

    // write
    public async Task AddAsync(Domain.Entities.User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

    }

    public async Task UpdateAsync(Domain.Entities.User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();

    }

    public async Task<Domain.Entities.User?> GetByIdAsync(long id)
    {
        return await _context.Users.FindAsync(id);
    }
}
