using System.Collections.Generic;
using PizzaWorld.Domian.Models;

namespace PizzaWorld.Domain.Abstracts
{
  public class APizzaModel : AEntity
  {

    // properties 
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Toppings> Toppings { get; set; }

    
    protected APizzaModel()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }
    //methods 
    protected virtual void AddCrust() { }
    protected virtual void AddSize() { }
    protected virtual void AddToppings() { }
  }
}