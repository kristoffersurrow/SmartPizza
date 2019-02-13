using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    class OrdinaryPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(string type)
        {

            switch (type)
            {
                case "Pepperoni":
                    return new PepperoniPizza();

                case "Rejermedtun":
                    return new RejerMedTunPizza();

                case "Skinke":
                    return new SkinkePizza();

                case "Kebab":
                    return new KebabPizza();

                default:
                    return null;
            }
         
        }

        public IPizza AddExtras(string type, IPizza pizza)
        {
            if (type == "Pepperoni")
            {
                return new PepperoniExtra(pizza);
            }
            else if (type == "Cheese")
            {
                return new CheeseExtra(pizza);
            }
            else if (type == "Family")
            {
                return new FamilyExtra(pizza);
            }
            else
            {
                return null;
            }
        }
    }
}
