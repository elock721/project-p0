using System;
using System.Collections.Generic;



namespace PizzaWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintAllStores();
        }
         static IEnumerable<Store> GetAllStores()
         {
             return new List<Store>(); 
             {
                new Store();
             };
        }
        static void PrintAllStores()
        {
            foreach(var store in GetAllStores())
            {
                System.Console.WriteLine(store);
            }
        }
    }
}
