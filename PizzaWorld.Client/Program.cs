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

            Console.WriteLine(" * * WELCOME TO THE PIZZA CONSOLE 5000 * * \n *  PLEASE SELECT A PIZZA STORE  *");
            
            foreach (var store in sqlclient.ReadStores())
            {
                System.Console.WriteLine(store.Name);
            }
        }

        static void AddToOrder(Order order)
        {
          Console.WriteLine("For Veggie Pizza: Select 1 \nFor Meat Pizza: Select 2 \nWhen Finished: Select 99");
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
                Console.WriteLine("For Veggie Pizza: Select 1 \nFor Meat Pizza: Select 2 \nWhen Finished: Select 99");
                selection = int.Parse(Console.ReadLine());
            }
        }

        static void RemovePizza(User user) 
        {
            var pizzas = user.Orders.Last().Pizzas;
            // pizzas.RemoveAt();
        }

        static void UserView()
        {

            List<User> users = sqlclient.FetchUsers();  

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("Order Count: " + users[i].Orders.Count); 
            }


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
                if (response == "R")
                {
                    
                }
                Console.WriteLine("Press 'A' to add Pizzas, 'R' to remove Pizzas or 'Enter' to finish order");
                response = Console.ReadLine();
            }

             Console.WriteLine("Your current order: ");


            //  sqlclient.SaveOrder(user.Orders.Last());

            // establishing ability to read and write to DB
             sqlclient.SaveUser(user);
            
            for (int i = 0; i < user.Orders.Count; i++)
            {
                Console.WriteLine(user.Orders[i]);
            };

            // print out all orders 
            // Console.WriteLine(users.Last().Orders.Last());
            
            
            
            
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
