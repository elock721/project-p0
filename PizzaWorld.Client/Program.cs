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
        private static readonly SqlClient sqlclient = new SqlClient();

        public Program()
        {
            _client2 = ClientSingleton.Instance;
        }

        static void Main(string[] args)
        {

            // PrintAllStores();
            UserView();
        }



        static void PrintAllStores()
        {
            foreach (var store in sqlclient.ReadStores())
            {
                System.Console.WriteLine(store.Name);
            }
        }

        static void AddToOrder(Order order)
        {
          Console.WriteLine("select 1 for veggie pizza or 2 for meat pizza, 99 when done");
            // convert int into 
            int selection = int.Parse(Console.ReadLine());
            
            while (selection < 99)
            {
                if (selection == 1)
                {
                    // making new veggie pizza
                    order.MakeVeggiePizza();
                }
                else
                {
                    order.MakeMeatPizza();
                }
                Console.WriteLine("select 1 for veggie pizza or 2 for meat pizza, 99 when done");
                selection = int.Parse(Console.ReadLine());
            }
        }

        static void UserView()
        {
            var user = new User();

            PrintAllStores();


            user.SelectedStore = sqlclient.FetchStore(Console.ReadLine());
            //intstantiate new obj of type Order
            

            //adding order to user
            user.Orders.Add(new Order());
            // calling last order added and adding to order
            AddToOrder(user.Orders.Last());
            Console.WriteLine(user.Orders.Count);

            // sqlclient.SaveUser(user);

            // for while loop for 
            Console.WriteLine("Your current order: ");
            for (int i = 0; i < user.Orders.Count; i++)
            {
                Console.WriteLine(user.Orders[i]);
            };

            Console.WriteLine("Press 'A' to add Pizzas, 'R' to remove Pizzas or 'Enter' to finish order");
            string response = Console.ReadLine();
            while (response != "")
            {
                if (response == "A")
                {
                    AddToOrder(user.Orders.Last());
                    Console.WriteLine(user.Orders.Count);
                }
                Console.WriteLine("Press 'A' to add Pizzas, 'R' to remove Pizzas or 'Enter' to finish order");
                response = Console.ReadLine();

            }
            Console.WriteLine("Your current order: ");
            for (int i = 0; i < user.Orders.Count; i++)
            {
                Console.WriteLine(user.Orders[i]);
            };
            // user.SelectedStore = _client.SelectStore();
            // user.SelectedStore.CreateOrder();
            // user.Orders.Add(user.SelectedStore.Orders.Last());
            // // while user.SelectPizza()
            // user.Orders.Last().MakeMeatPizza();
            // user.Orders.Last().MakeVeggiePizza();

            System.Console.WriteLine(user);
        }
    }
}
