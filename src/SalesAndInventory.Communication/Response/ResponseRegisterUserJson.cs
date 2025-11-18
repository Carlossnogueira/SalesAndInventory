

using SalesAndInventory.Domain.Enum;

namespace SalesAndInventory.Communication.Response;

public class ResponseRegisterUserJson
{
    public string Name { get; set; } = string.Empty;
    public string Login { get; set; } = string.Empty;
    public Qualification  Qualification { get; set; }
}