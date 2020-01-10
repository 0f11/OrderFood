using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class FoodItem
    {
        public int FoodItemId { get; set; }
        [Display(Name ="Dish Name")]
        public string FoodItemName { get; set; }
        public double Price { get; set; }
        [Display(Name ="Category")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
        public ICollection<FoodIngredient> Ingredients { get; set; }
        public bool IsOrdered { get; set; }
    }
}