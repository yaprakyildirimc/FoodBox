using FoodBox.Core.Entities;

namespace FoodBox.Entity.Entities
{
    public class Category : EntityBase
    {
        public String Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
