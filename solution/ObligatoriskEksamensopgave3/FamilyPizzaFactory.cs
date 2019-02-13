//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObligatoriskEksamensopgave3
//{
//    class FamilyPizzaFactory : IPizzaFactory
//    {
//        public IPizza CreatePizza(string type)
//        {
//            if (type == "Pepperoni")
//            {
//                return new FamilyPepperoniPizza();
//            }
//            else if (type == "Rejermedtun")
//            {
//                return new FamilyRejerMedTunPizza();
//            }
//            else
//            {
//                return null;
//            }
//        }

//        public IPizza AddExtras(string type, IPizza pizza)
//        {
//            if (type == "Pepperoni")
//            {
//                return new PepperoniExtra(pizza);
//            }
//            else if (type == "Cheese")
//            {
//                return new CheeseExtra(pizza);
//            }
//            else
//            {
//                return null;
//            }
//        }

//    }
//}
