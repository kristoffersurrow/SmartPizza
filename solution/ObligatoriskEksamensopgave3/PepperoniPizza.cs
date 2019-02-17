using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    public class PepperoniPizza : IPizza
    {
        public string Name() { return "Pepperoni Pizza"; }

        public double Price() { return 59; }

        public double Calories() { return 253; }

    }
}
