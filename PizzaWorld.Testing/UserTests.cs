using PizzaWorld.Domian.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class UserTests
    {
        [Fact]
        private void Test_UserExists()
        {
            
            var sut = new User();
            User sut1 = new User();

            var actual = sut; 

            Assert.IsType<User>(actual);
            Assert.NotNull(actual); 
        }
    }
}