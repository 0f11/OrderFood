using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL;
using Domain;

namespace OrderFood.Pages_Admin_FoodItem
{
    public class IndexModel : PageModel
    {
        private readonly DAL.AppDbContext _context;

        public IndexModel(DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<FoodItem> FoodItem { get;set; }

        public async Task OnGetAsync()
        {
            FoodItem = await _context.FoodItems
                .Include(f => f.Category).ToListAsync();
        }
    }
}
