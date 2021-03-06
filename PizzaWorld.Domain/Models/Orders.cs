using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
  public class Order : AEntity
  {
    private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

    public List<APizzaModel> Pizzas { get; set; }

    public Order()
    {
      Pizzas = new List<APizzaModel>();
    }

    public void MakeMeatPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
    }

    public void MakeVeggiePizza()
    {
      Pizzas.Add(_pizzaFactory.Make<VeggiePizza>()); 
    }
    // 
     public override string ToString()
    {
      string output = "";
      for (int i = 0; i < Pizzas.Count; i++)
      {
        output+= Pizzas[i] + "\n";          
      } 
      return output; 
    }
  }
}