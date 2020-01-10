using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<FoodIngredient> FoodIngredient { get; set; }
        
        public AppDbContext(DbContextOptions option) : base(option)
        {
            
        }
    }
}