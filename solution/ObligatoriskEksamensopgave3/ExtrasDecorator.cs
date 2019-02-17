using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    public abstract class ExtrasDecorator : IPizza
    {
        protected IPizza pizza;

        public abstract string Name();

        public virtual double Price()
        {
            return pizza.Price();
        }

        public virtual double Calories()
        {
            return pizza.Calories();
        }

        //Constructor
        public ExtrasDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }
    }
}
