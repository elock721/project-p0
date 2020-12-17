using PizzaWorld.Domian.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            
            var sut = new Pizza();
            Pizza sut1 = new Pizza();

            var actual = sut; 

            Assert.IsType<Pizza>(actual);
            Assert.NotNull(actual); 
        }
    }
}