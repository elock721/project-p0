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
  }
}