using SalesAndInventory.Communication.Enum;

namespace SalesAndInventory.Communication.Request;

public class RequestRegisterUserJson
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Qualification  Qualification { get; set; }
}