﻿using System;
using System.Collections.Generic;
using PizzaWorld.Domian.Models;
using PizzaWorld.Domian.Singletons;

namespace PizzaWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = ClientSingleton.Instance;
           //PrintAllStores();

            cs.MakeAStore(); 

        }
         static IEnumerable<Store> GetAllStores()
         {
             return new List<Store>()
             {
                new Store(),
                new Store()
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
