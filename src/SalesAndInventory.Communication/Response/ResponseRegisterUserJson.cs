

using SalesAndInventory.Domain.Enum;

namespace SalesAndInventory.Communication.Response;

public class ResponseRegisterUserJson
{
    public string Name { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
}