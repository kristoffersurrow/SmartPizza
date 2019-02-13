using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    class CheeseExtra : ExtrasDecorator
    {
        public override string Name() { return pizza.Name() + ", Extra Ost"; }

        public override double Price() { return pizza.Price() + 6; } 

        public override double Calories() { return pizza.Calories() + 40; }

        public CheeseExtra(IPizza pizza) : base(pizza) { }
    }
}
