using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    public class OrdinaryPizzaFactory : IPizzaFactory
    {
        //Pizza laves, og decorators tilføjes
        public IPizza MakePizza(List<string> _extrasList, string _pizzaType)
        {
            IPizza pizza = CreatePizza(_pizzaType);

            foreach (string extra in _extrasList)
            {
                pizza = AddExtras(extra, pizza);
            }

            return pizza;
        }


        private IPizza CreatePizza(string type)
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

        private IPizza AddExtras(string type, IPizza pizza)
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
