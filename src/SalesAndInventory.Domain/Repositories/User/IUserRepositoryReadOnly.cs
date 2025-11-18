namespace SalesAndInventory.Domain.Repositories.User;

using SalesAndInventory.Domain.Entities;

public interface IUserRepositoryReadOnly
{
    Task<User?> GetUserAsync(long userId);

    Task<bool> UserExistsWithSameLogin(string login);
}