using Microsoft.EntityFrameworkCore;
using SalesAndInventory.Domain.Entities;

namespace SalesAndInventory.Infrastructure;

public class SalesAndInventoryContext : DbContext
{
    public SalesAndInventoryContext(DbContextOptions<SalesAndInventoryContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
}