using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    class SkinkePizza : IPizza
    {
        public string Name() { return "Skinke Pizza"; }

        public double Price() { return 55; }

        public double Calories() { return 245; }
    }
}
