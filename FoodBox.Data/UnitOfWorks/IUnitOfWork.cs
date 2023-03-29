using FoodBox.Core.Entities;
using FoodBox.Data.Repositories.Abstract;

namespace FoodBox.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();

        Task<int> SaveAsync();
        int Save();
    }
}
