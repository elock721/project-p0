using System.Collections.Generic;

namespace PizzaWorld.Domian.Models 
{
    public class User
    {
        public List<Order> Orders { get; set; }
        public Store SelectedStore { get; set; }

        public override string ToString()
        {
            return $"I have selected this store: {SelectedStore}"; 
        }
    }
}