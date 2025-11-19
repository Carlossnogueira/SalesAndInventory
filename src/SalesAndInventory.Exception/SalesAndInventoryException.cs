namespace SalesAndInventory.Exception;

public abstract class SalesAndInventoryException : SystemException
{
     protected SalesAndInventoryException(string message) : base(message){}
     
     public abstract int StatusCode { get; }
     public abstract List<string> GetErrors();
}