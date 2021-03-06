using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client
{
  public class SqlClient
  {
    private readonly PizzaWorldContext _db = new PizzaWorldContext();

    public SqlClient()
    {
      if (ReadStores().Count() == 0)
      {
        CreateStore();
      }
    }

    public IEnumerable<Store> ReadStores()
    {
      return _db.Stores;
    }

    public void Save(Store store)
    {
      _db.Add(store); // git add
      _db.SaveChanges(); // git commit
    }
    public void SaveUser(User user)
    {
      _db.Add(user); // git add
      _db.SaveChanges(); // git commit
    }

    public void CreateStore()
    {
      Save(new Store());
    }

    public Store FetchStore(string input)
    {
      return _db.Stores.FirstOrDefault(s => s.Name == input);
    }

    public List<User> FetchUsers()
    {
      // return _db.Users.ToList();
      var u = _db.Users.ToList(); 
      return u; 

    }

    // public List<Order> FetchUserOrders(User user)
    // {
    //   _db.Orders.
    // }

    // public List<Order> FetchOrders()
    // {
    //   return _db.
    // }

    // Save Order to order table 
    public void SaveOrder(Order order)
    {
      _db.Add(order); 
      _db.SaveChanges();
    }
  }
}