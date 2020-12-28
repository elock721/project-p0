using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{
  public class PizzaWorldContext : DbContext
  {
    public DbSet<Store> Stores { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("Server=tcp:elpizzaworlddb.database.windows.net,1433;Initial Catalog=PizzaWorldDB;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Store>().HasKey(s => s.EntityId);
      builder.Entity<User>().HasKey(u => u.EntityId);
      builder.Entity<Order>().HasKey(o => o.EntityId);
      builder.Entity<APizzaModel>().HasKey(p => p.EntityId);
    }
  }
}
