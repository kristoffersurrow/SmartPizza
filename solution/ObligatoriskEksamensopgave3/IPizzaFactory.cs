using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    public interface IPizzaFactory
    {
        IPizza MakePizza(List<string> ekstrasList, string pizzaType);
    }
}
