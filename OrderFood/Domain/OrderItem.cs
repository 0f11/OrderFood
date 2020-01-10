using System.Collections.Generic;

namespace Domain
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        public int FoodItemId { get; set; }
        public FoodItem? FoodItem { get; set; }
        public double Sum { get; set; }
        
        
    }
}