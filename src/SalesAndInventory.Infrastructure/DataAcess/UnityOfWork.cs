using System;
using SalesAndInventory.Domain.Repositories;

namespace SalesAndInventory.Infrastructure.DataAcess;

public class UnityOfWork : IUnityOfWork
{

    private readonly SalesAndInventoryContext _context;

    public UnityOfWork(SalesAndInventoryContext context)
    {
        _context = context;
    }

    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }
}
