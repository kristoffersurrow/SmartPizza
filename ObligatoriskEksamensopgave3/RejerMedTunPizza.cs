using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskEksamensopgave3
{
    class RejerMedTunPizza : IPizza
    {
        public string Name() { return "Rejer Med Tun Pizza"; }

        public double Price() { return 64; } 

        public double Calories() { return 231; }

    }
}
