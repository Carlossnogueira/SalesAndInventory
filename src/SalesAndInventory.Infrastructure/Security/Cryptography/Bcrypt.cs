using SalesAndInventory.Domain.Security.Cryptography;

using BC = BCrypt.Net.BCrypt;

namespace SalesAndInventory.Infrastructure.Security.Cryptography;

public class Bcrypt : IEncrypter
{
    public string Encrypt(string password)
    {
        string passwordHash = BC.HashPassword(password);

        return passwordHash;
    }
}