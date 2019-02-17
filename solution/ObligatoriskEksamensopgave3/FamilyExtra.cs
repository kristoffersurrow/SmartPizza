using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    public class FamilyExtra : ExtrasDecorator
    {
        public override string Name() { return "Familie " + pizza.Name(); }

        public override double Price() { return pizza.Price() * 1.5; }

        public override double Calories() { return pizza.Calories() * 1.5; }

        public FamilyExtra(IPizza pizza) : base(pizza) { }
    }
}
