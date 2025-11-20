using SalesAndInventory.Domain.Entities;

namespace SalesAndInventory.Domain.Security.Token;

public interface IAccessTokenGenerator
{
    string Generate(User user);
}