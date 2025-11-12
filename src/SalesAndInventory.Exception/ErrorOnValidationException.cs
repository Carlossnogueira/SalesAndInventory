namespace SalesAndInventory.Exception;

public class ErrorOnValidationException : SalesAndInventoryException
{
    public List<string> Errors { get; set; }

    public ErrorOnValidationException(List<string> errorMessages)
    {
        Errors = errorMessages;
    }
}