using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DAL;
using Domain;

namespace OrderFood.Pages_Admin_OrderItem
{
    public class CreateModel : PageModel
    {
        private readonly DAL.AppDbContext _context;
        public SelectList FootItemSelectedList { get; set; }
        public SelectList PersonSelectedList { get; set; }

        public CreateModel(DAL.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            FootItemSelectedList = new SelectList(_context.FoodItems, nameof(FoodItem.FoodItemId),nameof(FoodItem.FoodItemName));
            PersonSelectedList = new SelectList(_context.Persons, nameof(Person.PersonId), nameof(Person.PersonName));
            return Page();
        }

        [BindProperty]
        public OrderItem OrderItem { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderItems.Add(OrderItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
