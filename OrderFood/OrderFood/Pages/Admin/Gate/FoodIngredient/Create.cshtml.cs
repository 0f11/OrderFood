using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DAL;
using Domain;

namespace OrderFood.Pages_Admin_FoodIngredient
{
    public class CreateModel : PageModel
    {
        private readonly DAL.AppDbContext _context;
        public SelectList FoodItemSelectedList { get; set; }

        public CreateModel(DAL.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        FoodItemSelectedList = new SelectList(_context.FoodItems, nameof(FoodItem.FoodItemId), nameof(FoodItem.FoodItemName));
            return Page();
        }

        [BindProperty]
        public FoodIngredient FoodIngredient { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FoodIngredient.Add(FoodIngredient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
