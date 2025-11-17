using Microsoft.EntityFrameworkCore;
using SalesAndInventory.Domain.Entities;
using SalesAndInventory.Domain.Entities.Adress;

namespace SalesAndInventory.Infrastructure;


// TODO run migration
public class SalesAndInventoryContext : DbContext
{
    public SalesAndInventoryContext(DbContextOptions<SalesAndInventoryContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Adress> Adresses { get; set; }
}