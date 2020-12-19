using System;
using System.Collections.Generic;
using PizzaWorld.Domian.Models;
using PizzaWorld.Domian.Singletons;

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
            _client.MakeAStore(); 

            PrintAllStores();
            System.Console.WriteLine(_client.SelectStore());

        }
         static IEnumerable<Store> GetAllStores()
         {
           return _client.Stores;  
        }
        static void PrintAllStores()
        {
            foreach(var store in GetAllStores())
            {
                System.Console.WriteLine(store);
            }
        }
        static void UserView()
        {
            var user = new User(); 
            
            PrintAllStores();
            
            // user.SelectedStored = _client.SelectStore();
            // user.SelectedStore.CreateOrder();
            // user.Orders = user.SelectedStore.Orders.Last(); 
            //while user.SelectPizza()
            // user.Orders.Last().MakeMeatPizza();
            // user.Orders.Last().MakeMeatPizza();

            System.Console.WriteLine(user);
            
        }
    }
}
