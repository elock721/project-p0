using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domian.Models
{
    public class Size : AEntity
    {
         public string Name { get; set; }
         public decimal Price { get; set; }

         public Size()
         {

         }
         public Size(string name, decimal price)
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