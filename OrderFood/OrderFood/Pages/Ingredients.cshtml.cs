using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Domain;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace OrderFood
{
    public class Ingredients : PageModel
    {
        private readonly DAL.AppDbContext _context;

        public string FoodItemToShow { get; set; }
        public IList<FoodIngredient> FoodIngredients { get; set; }

        public Ingredients(AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGet(int foodItemId)
        {
            var queryFoodIngredients = _context.FoodIngredient.Where(n => n.FoodItemId == foodItemId).AsQueryable();
            FoodIngredients = await queryFoodIngredients.ToListAsync();

            var qFoodItem = _context.FoodItems.First(n => n.FoodItemId == foodItemId);
            FoodItemToShow = qFoodItem.FoodItemName;
        }
    }
}