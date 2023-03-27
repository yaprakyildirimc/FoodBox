using FoodBox.Core.Entities;

namespace FoodBox.Entity.Entities
{
    public class Product : EntityBase
    { 
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }


        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
