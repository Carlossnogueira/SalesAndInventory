using System.Net;

namespace SalesAndInventory.Exception;

public class UserNotFoundException : SalesAndInventoryException
{
    private readonly List<string> _error;
    
    UserNotFoundException() : base(string.Empty)
    {
        _error = ["User not Found"];
    }
    public override int StatusCode => (int)HttpStatusCode.NotFound;
    
    public override List<string> GetErrors()
    {
        return _error;
    }
}
