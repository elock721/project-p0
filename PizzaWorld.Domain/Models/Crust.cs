using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domian.Models
{
    public class Crust : AEntity
    {

         public string Name { get; set; }
         public decimal Price { get; set; }

         public Crust()
         {

         }
         //custom constructor
         public Crust(string name, decimal price)
         {
             //empty object
             this.Name = name;
             this.Price = price;
             
         }
        // default method - have to override  
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}