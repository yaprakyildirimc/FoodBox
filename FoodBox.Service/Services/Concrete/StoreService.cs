using AutoMapper;
using FoodBox.Data.UnitOfWorks;
using FoodBox.Entity.DTOs.Products;
using FoodBox.Entity.DTOs.Stores;
using FoodBox.Entity.Entities;
using FoodBox.Service.Services.Abstract;

namespace FoodBox.Service.Services.Concrete
{
    public class StoreService : IStoreService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public StoreService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<StoreDto>> GetAllStoresWithNonDeleted()
        {
            var stores = await unitOfWork.GetRepository<Store>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<StoreDto>>(stores);

            return map;
        }
    }
}
