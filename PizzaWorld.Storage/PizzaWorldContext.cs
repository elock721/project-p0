using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domian.Models;

namespace PizzaWorld.Storing
{
  public class PizzaWorldContext : DbContext
  {
    public DbSet<Store> Stores { get; set; }
    public DbSet<User> Users { get; set; }
    // public DbSet<Order> Orders { get; set; }
    // public DbSet<Toppings> Toppings { get; set; }
    // public DbSet<Crust> Crusts { get; set; }
    // public DbSet<Size> Sizes { get; set; }

    


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("Server=elpizzaworlddb.database.windows.net;Initial Catalog=ejlpizzaworlddb;User ID=sqladmin;Password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Store>().HasKey(s => s.EntityId);
      builder.Entity<User>().HasKey(u => u.EntityId);
      builder.Entity<Order>().HasKey(o => o.EntityId);
      builder.Entity<APizzaModel>().HasKey(p => p.EntityId);
      builder.Entity<Size>().HasKey(p => p.EntityId);
      builder.Entity<Crust>().HasKey(p => p.EntityId);
      builder.Entity<Toppings>().HasKey(p => p.EntityId);
      builder.Entity<Store>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<User>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<Order>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<APizzaModel>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<Size>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<Crust>().Property(p => p.EntityId).ValueGeneratedNever();
      builder.Entity<Toppings>().Property(p => p.EntityId).ValueGeneratedNever();

      
      SeedData(builder); 
    }

    private void SeedData(ModelBuilder builder)
    {
      builder.Entity<Store>().HasData(new List<Store>
        {
          new Store() {Name = "Home Slice"},
          new Store() {Name = "Pinthouse Pizza Co"}
        }
      );
      builder.Entity<Size>().HasData(new List<Size>
        {
          new Size() {Name = "Large", Price = 15},
          new Size() {Name = "Medium", Price = 12},
          new Size() {Name = "Small", Price = 9},
        }
      );
      builder.Entity<Crust>().HasData(new List<Crust>
        {
          new Crust() {Name = "Brooklyn", Price = 2},
          new Crust() {Name = "Deep Dish", Price = 3},
          new Crust() {Name = "Hand Tossed", Price = 1},
        }
      );
      builder.Entity<Toppings>().HasData(new List<Toppings>
        {
          new Toppings() {Name = "Cheese", Price = 0},
          new Toppings() {Name = "Pepperoni", Price = 1},
          new Toppings() {Name = "Pineapple", Price = 1},
          new Toppings() {Name = "Bell Pepper", Price = 1},
          new Toppings() {Name = "Bacon", Price = 2}
        }
      );
    }
  }
}