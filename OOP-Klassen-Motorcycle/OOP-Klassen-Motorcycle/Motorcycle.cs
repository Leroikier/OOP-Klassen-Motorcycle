using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Klassen_Motorcycle
{
    class Motorcycle
    {
        public bool Started;
        public int Rpm;
        public int Gear;

        public string Name { get; set; }

        public Motorcycle()
        {
            Started = false;
            Rpm = 0;
            Gear = 0;
            Name = "";
        }

        public Motorcycle(bool Started, int Rpm, int Gear, string Name)
        {
            Started = true;
            Rpm = 1000;
            Gear = 0;
            Name = "";
        }
    }
}
