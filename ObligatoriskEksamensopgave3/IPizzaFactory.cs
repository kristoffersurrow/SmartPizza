using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    interface IPizzaFactory
    {
        IPizza CreatePizza(string type);

        IPizza AddExtras(string type, IPizza pizza);
    }
}
