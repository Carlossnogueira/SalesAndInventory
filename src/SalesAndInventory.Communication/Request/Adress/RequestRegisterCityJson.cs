using System;

namespace SalesAndInventory.Communication.Request.Adress;

public class RequestRegisterCityJson
{

    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int StateId { get; set; }


}
