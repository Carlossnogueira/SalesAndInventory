using System;

namespace SalesAndInventory.Communication.Request.Adress;

public class RequestRegisterAdressJson
{
    public long Id { get; set; }

    public string Street { get; set; } = string.Empty;


    public string Number { get; set; } = string.Empty;

    public string Neighborhood { get; set; } = string.Empty;

    public int CityId { get; set; }

}
