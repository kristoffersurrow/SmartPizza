using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ObligatoriskEksamensopgave3;

namespace UnitTests
{
    public class OrdinaryPizzaFactory_Tests
    {
        [Fact]
        public void ShouldMakePizzaOfSameType()
        {
            //Arrange
            List<string> extrasList = new List<string>() { "Cheese", "Family" };
            string pizzaType = "Pepperoni";
            IPizzaFactory pizzaFactory = new OrdinaryPizzaFactory();

            //Act
            IPizza pizzaFromFactory = pizzaFactory.MakePizza(extrasList,pizzaType);

            //Assert
            IPizza pizza = new FamilyExtra(new CheeseExtra(new PepperoniPizza()));

            Assert.NotNull(pizzaFromFactory);

            Assert.Equal(pizza.Price(), pizzaFromFactory.Price());
            Assert.Equal(pizza.Name(), pizzaFromFactory.Name());
            Assert.Equal(pizza.Calories(), pizzaFromFactory.Calories());
        }
    }
}
