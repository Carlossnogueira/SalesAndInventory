namespace SalesAndInventory.Domain.Repositories.User;

using SalesAndInventory.Domain.Entities;

public interface IUserRepositoryWriteOnly
{
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task<User?> GetByIdAsync(long id);
}