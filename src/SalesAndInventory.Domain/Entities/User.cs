using SalesAndInventory.Domain.Enum;

namespace SalesAndInventory.Domain.Entities;

public class User
{
    public long Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Qualification Qualification { get; set; } = Qualification.Employee;
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public Guid UserIdentifier  { get; set; }
}