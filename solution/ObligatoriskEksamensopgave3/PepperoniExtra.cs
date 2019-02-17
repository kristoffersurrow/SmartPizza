using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    public class PepperoniExtra : ExtrasDecorator
    {
        public override string Name() { return pizza.Name() + ", Extra Pepperoni"; }

        public override double Price() { return pizza.Price() + 8; }

        public override double Calories() { return pizza.Calories() + 25; }

        public PepperoniExtra(IPizza pizza) : base(pizza) { }
    }
}
