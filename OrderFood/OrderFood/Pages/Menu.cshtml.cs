using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace OrderFood.Pages
{
    public class Menu : PageModel
    {
        private readonly DAL.AppDbContext _context;
        public IList<FoodItem> Items { get; set; }
        public List<OrderItem> OrderedItems { get; set; }
        public int SavedPersonId { get; set; }
        public double SumToShow { get; set; }

        public string? Search { get; set; }

        public Menu(AppDbContext context)
        {
            _context = context;
            
        }

        public async Task<ActionResult> OnGetAsync(int? foodItemId, int? personId, int? removeItemId,string? search, string? toDoActionReset)
        {
            
            if (toDoActionReset == "Reset")
            {
                Search = "";
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(search))
                    Search = search.Trim();
            }
            var itemsQuery = _context.FoodItems.Include(o=> o.Category).AsQueryable();
            if (!string.IsNullOrWhiteSpace(Search))
            {
                if (Search.Contains("%21"))
                {
                    itemsQuery = itemsQuery.Where(b => 
                                        !b.FoodItemName.Contains(Search) ||
                                        !b.Category.CategoryName.Contains(Search));
                }
                else
                {
                    itemsQuery = itemsQuery.Where(b => 
                        b.FoodItemName.Contains(Search) ||
                        b.Category.CategoryName.Contains(Search));
                }
               

            }

            SavedPersonId = personId.Value;
            if (removeItemId.HasValue)
            {
                var dOrderItems = _context.OrderItems.First(n => n.OrderItemId == removeItemId && n.PersonId == personId);
                _context.Attach(dOrderItems);
                _context.Remove(dOrderItems);
                _context.SaveChanges();
            }
            if (!foodItemId.Equals(null) && personId.HasValue)
            {
                
                var newFoodItem = _context.FoodItems.First(n => n.FoodItemId == foodItemId);
                var newOrderItem = new OrderItem()
                {
                    PersonId = personId.Value,
                    FoodItem = newFoodItem,
                    FoodItemId = newFoodItem.FoodItemId,
                    Sum = newFoodItem.Price 
                };
                _context.OrderItems.Add(newOrderItem);
                await _context.SaveChangesAsync();
            }

            itemsQuery = itemsQuery.OrderBy((b => b.Category.CategoryId));
            Items = await itemsQuery.ToListAsync();
            
            //var orderedItem = _context.OrderItems.First(n => n.OrderItemId == orderItemId);
            //var personId = orderedItem.PersonId;

            var orderedItemsQuery =
                _context.OrderItems
                    .Where(n => n.PersonId == personId)
                    .AsQueryable()
                    .Include(o => o.FoodItem)
                    .Include(o=> o.FoodItem.Category);
            OrderedItems = await orderedItemsQuery.ToListAsync();

            return Page();
        }
        
    }
}