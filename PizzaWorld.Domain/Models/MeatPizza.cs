using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domian.Models;

namespace PizzaWorld.Domain.Models
{
  public class MeatPizza : APizzaModel
  {
    protected override void AddCrust()
    {
      Crust = new Crust();
    }

    protected override void AddSize()
    {
      Size = new Size();
    }

    protected override void AddToppings()
    {
      Toppings = new List<Toppings>
      {
        new Toppings("cheese", 0),
        new Toppings("pepperoni", 1),
        new Toppings("bacon", 1)
      };
    }
    public override string ToString()
    {
      string output = "Meat Pizza"; 
      return output; 
    }
  }
}