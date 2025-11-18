namespace SalesAndInventory.Domain.Security.Cryptography;

public interface IEncrypter
{
    string Encrypt(string text);
}