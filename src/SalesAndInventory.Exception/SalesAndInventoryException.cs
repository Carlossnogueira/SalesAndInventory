namespace SalesAndInventory.Exception;

public abstract class SalesAndInventoryException : SystemException
{
     public SalesAndInventoryException() { }
     public SalesAndInventoryException(string message) : base(message){}
}