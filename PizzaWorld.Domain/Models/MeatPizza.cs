using System.Collections.Generic;
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
       
      };
    }
  }
}