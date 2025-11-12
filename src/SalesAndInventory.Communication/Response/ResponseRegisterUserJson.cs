using SalesAndInventory.Communication.Enum;

namespace SalesAndInventory.Communication.Response;

public class ResponseRegisterUserJson
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Qualification  Qualification { get; set; }
}