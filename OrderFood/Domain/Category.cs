using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Display(Name ="Gategory Name")]
        public string CategoryName { get; set; } = default!;
    }
}