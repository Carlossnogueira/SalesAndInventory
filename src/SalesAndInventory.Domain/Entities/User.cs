using SalesAndInventory.Domain.Enum;

namespace SalesAndInventory.Domain.Entities;

public class User
{
    public long Id { get; set; } 
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Qualification Qualification { get; set; } = Qualification.Employee;
    public bool IsDeleted { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string UserIdentifier  { get; set; } = string.Empty;
}