using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Domain;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace OrderFood
{
    public class CompletedOrder : PageModel
    {
        private readonly DAL.AppDbContext _context;
        public List<OrderItem> OrderedItems2 { get; set; }
        
        public double Sum { get; set; }

        public string Name { get; set; }

        public CompletedOrder(AppDbContext context)
        {
            _context = context;
        }

        public async void OnGetAsync(int personId)
        {    
            var orderedItemsQuery2 = _context.OrderItems.Where(n => n.PersonId == personId).Include(o=>o.FoodItem).AsQueryable();
            OrderedItems2 = await orderedItemsQuery2.ToListAsync();
            foreach (var item in OrderedItems2)
            {
                Sum += item.Sum;
            }

            var person = _context.Persons.First(n => n.PersonId == personId);

            Name = person.PersonName;
            
            var order = _context.Orders.First(n => n.OrderId == person.OrderId);
            order.OrderSum = (int) Sum;
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();


        }
    }
}