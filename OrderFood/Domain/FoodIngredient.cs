using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class FoodIngredient
    {
        public int FoodIngredientId { get; set; }
        public string Ingredient { get; set; }
        [Display(Name ="Dish")]
        public int FoodItemId { get; set; }

        [Display(Name = "Dish")] public FoodItem? FoodItem { get; set; }
    }
}