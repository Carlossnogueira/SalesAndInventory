using SalesAndInventory.Domain.Repositories;
using SalesAndInventory.Domain.Repositories.User;

namespace SalesAndInventory.Infrastructure.DataAcess.Repositories;


public class UserRepositoryWriteOnly : IUserRepositoryWriteOnly
{
    private readonly SalesAndInventoryContext _context;
    private readonly IUnityOfWork _unitOfWork;

    public UserRepositoryWriteOnly(SalesAndInventoryContext context, IUnityOfWork unityOfWork)
    {
        _context = context;
        _unitOfWork = unityOfWork;
    }

    public async Task AddAsync(Domain.Entities.User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        await _unitOfWork.Commit();
    }

    public async Task UpdateAsync(Domain.Entities.User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        await _unitOfWork.Commit();
    }

    public async Task<Domain.Entities.User?> GetByIdAsync(long id)
    {
        return await _context.Users.FindAsync(id);
    }
}
