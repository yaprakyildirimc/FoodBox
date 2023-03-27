using FoodBox.Core.Entities;

namespace FoodBox.Entity.Entities
{
    public class Store : EntityBase
    { 
        public string StoreName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        ICollection<Product> Products { get; set; }
    }
}
