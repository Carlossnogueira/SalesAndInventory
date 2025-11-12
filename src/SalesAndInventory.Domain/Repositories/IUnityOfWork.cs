using System;

namespace SalesAndInventory.Domain.Repositories;

public interface IUnityOfWork
{
    Task Commit();
}
