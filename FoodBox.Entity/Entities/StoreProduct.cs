using FoodBox.Core.Entities;

namespace FoodBox.Entity.Entities
{
    public class StoreProduct : EntityBase
    {
        public Store Store { get; set; }

        public Product Product { get; set; }

        public Guid StoreId { get; set; }

        public Guid ProductId { get; set; }
    }
}
