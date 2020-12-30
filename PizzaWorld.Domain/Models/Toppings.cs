using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domian.Models
{
    public class Toppings : AEntity
    {
         public string Name { get; set; }
         public decimal Price { get; set; }

         public Toppings()
         {

         }
         public Toppings(string name, decimal price)
         {
             this.Name = name;
             this.Price = price;
             
         }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}