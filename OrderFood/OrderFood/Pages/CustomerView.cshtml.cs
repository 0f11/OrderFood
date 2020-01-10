using System.Threading.Tasks;
using DAL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OrderFood.Pages
{
    public class CustomerView : PageModel
    {
        [BindProperty]
        public Person Person { get; set; }

        private readonly DAL.AppDbContext _context;

        public CustomerView(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();
            var newOrder = new Order();
            _context.Orders.Add(newOrder);
            await _context.SaveChangesAsync();
            var newPerson = new Person()
            {
                PersonName = Person.PersonName,
                OrderId = newOrder.OrderId
            };
            
            _context.Persons.Add(newPerson);
            
            await _context.SaveChangesAsync();
            return RedirectToPage("./Menu", new {personId = newPerson.PersonId});

        }
    }
}