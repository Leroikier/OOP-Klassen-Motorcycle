using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Klassen_Motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle mc1 = new Motorcycle { Started = true, Rpm = 5000, Gear = 4, Name = "Honda", Hastighed = 0 };

            //mc1.SetRpm(2000);

            //mc1.isStarted();

            //mc1.Start();

            //mc1.Stop();

            //mc1.isStarted();

            mc1.GetSpeed();
            //Console.WriteLine(mc1.Hastighed);

            //mc1.ShiftGearsUp();

            //mc1.ShiftGearsDown(3);

            //mc1.GetGear();
            mc1.ToString();

            Console.WriteLine(mc1.ToString());

            Console.ReadKey();
        }
    }
}
