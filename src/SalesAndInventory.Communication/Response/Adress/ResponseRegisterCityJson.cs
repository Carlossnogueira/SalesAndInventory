using System;

namespace SalesAndInventory.Communication.Response.Adress;

public class ResponseRegisterCityJson
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int StateId { get; set; }
}
