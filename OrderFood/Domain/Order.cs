using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Order
    {
        [Display(Name ="Order Id")]
        public int OrderId { get; set; }
        [Display(Name ="Total sum of order")]
        public int OrderSum { get; set; }

    }
}