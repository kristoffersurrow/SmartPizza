using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    public class KebabPizza : IPizza
    {
        public string Name() { return "Kebab Pizza"; }

        public double Price() { return 62; }

        public double Calories() { return 255; }
    }
}
