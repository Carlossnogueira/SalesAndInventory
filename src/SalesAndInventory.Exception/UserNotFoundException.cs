using System;

namespace SalesAndInventory.Exception;

public class UserNotFoundException : SalesAndInventoryException
{
    UserNotFoundException() : base("User not found") { }
}
