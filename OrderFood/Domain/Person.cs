using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Person
    {
        public int PersonId { get; set; }
        [Display(Name ="Person name")]
        public string PersonName { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        
    }
}