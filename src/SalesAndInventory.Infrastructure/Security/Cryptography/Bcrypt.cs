using SalesAndInventory.Domain.Security.Cryptography;

using BC = BCrypt.Net.BCrypt;

namespace SalesAndInventory.Infrastructure.Security.Cryptography;

public class Bcrypt : IEncrypter
{
    public string Encrypt(string text)
    {
        return BC.HashPassword(text);
    }
}