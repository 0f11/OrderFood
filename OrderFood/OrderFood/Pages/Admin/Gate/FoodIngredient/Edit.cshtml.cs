using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL;
using Domain;

namespace OrderFood.Pages_Admin_FoodIngredient
{
    public class EditModel : PageModel
    {
        private readonly DAL.AppDbContext _context;

        public EditModel(DAL.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["FoodItemId"] = new SelectList(_context.FoodItems, "FoodItemId", "FoodItemId");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FoodIngredient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodIngredientExists(FoodIngredient.FoodIngredientId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FoodIngredientExists(int id)
        {
            return _context.FoodIngredient.Any(e => e.FoodIngredientId == id);
        }
    }
}
