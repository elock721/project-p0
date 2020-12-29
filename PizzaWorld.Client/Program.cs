using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
  class Program
  {
    private static readonly ClientSingleton _client = ClientSingleton.Instance;
    private readonly ClientSingleton _client2;

    public Program()
    { 
      _client2 = ClientSingleton.Instance;
    }

    static void Main(string[] args)
    {
      // Store staples = new Store(99);
      
      UserView();
    }

    static void PrintAllStores()
    {
      foreach (var store in _client.Stores)
      {
        System.Console.WriteLine(store);
      }
    }

    static void UserView()
    {
      var user = new User();

      PrintAllStores();

      user.SelectedStore = _client.SelectStore();
      user.SelectedStore.CreateOrder();
      user.Orders.Add(user.SelectedStore.Orders.Last());
      // while user.SelectPizza()
      user.Orders.Last().MakeMeatPizza();
      user.Orders.Last().MakeMeatPizza();
      user.Orders.Last().MakeVeggiePizza();

      System.Console.WriteLine(user);
    }
  }
}
