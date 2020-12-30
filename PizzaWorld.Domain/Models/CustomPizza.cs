using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domian.Models;

namespace PizzaWorld.Domain.Models
{
    public class CustomPizza : APizzaModel
    {
        public CustomPizza()
        {
            
        }

        public CustomPizza(Crust crust, Size size, List<Toppings> toppings)
        {
            this.Crust = crust;
            this.Size = size;
            this.Toppings = toppings; 
        }
    }
}