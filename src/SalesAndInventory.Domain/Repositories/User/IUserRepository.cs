namespace SalesAndInventory.Domain.Repositories.User;

using SalesAndInventory.Domain.Entities;

public interface IUserRepository
{
    Task<User?> GetUserAsync(long userId);
}