using PizzaWorld.Domian.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class StoreTests
    {
        [Fact]
        private void Test_StoreExists()
        {
            
            var sut = new Store();
            Store sut1 = new Store();

            var actual = sut; 

            Assert.IsType<Store>(actual);
            Assert.NotNull(actual); 
        }
    }
}