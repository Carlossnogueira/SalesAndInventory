using SalesAndInventory.Domain.Repositories.User;
namespace SalesAndInventory.Infrastructure.DataAcess.Repositories.User;


public class UserRepositoryReadOnly : IUserRepositoryReadOnly
{
    private readonly SalesAndInventoryContext _context;
    public UserRepositoryReadOnly(SalesAndInventoryContext context)
    {
        _context = context;
    }

    public async Task<Domain.Entities.User?> GetUserAsync(long userId)
    {
        var result = await _context.Users.FindAsync(userId);
        return result;
    }
}
