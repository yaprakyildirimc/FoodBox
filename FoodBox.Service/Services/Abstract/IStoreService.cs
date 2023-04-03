using FoodBox.Entity.DTOs.Stores;

namespace FoodBox.Service.Services.Abstract
{
    public interface IStoreService
    {
        Task<List<StoreDto>> GetAllStoresWithNonDeleted();
    }
}
