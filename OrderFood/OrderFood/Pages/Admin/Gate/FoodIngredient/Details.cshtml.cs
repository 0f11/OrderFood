using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL;
using Domain;

namespace OrderFood.Pages_Admin_FoodIngredient
{
    public class DetailsModel : PageModel
    {
        private readonly DAL.AppDbContext _context;

        public DetailsModel(DAL.AppDbContext context)
        {
            _context = context;
        }

        public FoodIngredient FoodIngredient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FoodIngredient = await _context.FoodIngredient
                .Include(f => f.FoodItem).FirstOrDefaultAsync(m => m.FoodIngredientId == id);

            if (FoodIngredient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
