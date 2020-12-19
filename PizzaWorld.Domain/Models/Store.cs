using System.Collections.Generic;

namespace PizzaWorld.Domian.Models 
{
    public class Store
    {
        
        public List<Order> Orders { get; set; }
        
        
        // CRUD
        public void CreateOrder()
        {
            // var O = new Order();
            Orders.Add(new Order());
        }

        bool DeleteOrder(Order order)
        {
            try
            {
                Orders.Remove(order);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

