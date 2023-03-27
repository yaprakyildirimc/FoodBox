using FoodBox.Core.Entities;

namespace FoodBox.Entity.Entities
{
    public class StoreUser : EntityBase
    {
        public Guid Id { get; set; }
        public Store Store { get; set; }
    }
}
