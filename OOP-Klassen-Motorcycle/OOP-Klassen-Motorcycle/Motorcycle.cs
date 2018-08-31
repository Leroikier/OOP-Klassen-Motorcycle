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
        public int Hastighed;

        private string name;

        //Propfull
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Slukket tilstand
        public Motorcycle()
        {
            Started = false;
            Rpm = 0;
            Gear = 0;
        }

        //Tændt tilstand
        public Motorcycle(bool Started, string Navn)
        {
            if (Started == true)
            {
                Rpm = 1000;
            }
            else
            {
                Rpm = 0;
            }
            this.Started = Started;
            Gear = 0;
            name = Navn;
        }

        //Set rpm metode
        public void SetRpm(int Rpm)
        {
            if (Started == true)
            {
                if (Rpm > 8000)
                {
                    this.Rpm = 8000;
                    Console.WriteLine("Din Rpm er for høj : Den sættes til 8000");
                }
                else if (Rpm >= 1000)
                {
                    this.Rpm = Rpm;
                    Console.WriteLine("Motoren kører din Rpm er : " + Rpm);
                }
                else
                {
                    Started = false;
                    Gear = 0;
                    this.Rpm = 0;
                    Console.WriteLine("Motoren standser/slukker");
                }
            }
            else
            {
                Console.WriteLine("Motoren er slukket. Tænd den venligst");
            }
        }

        //Get rpm metode
        public void GetRpm()
        {
            Console.WriteLine(Rpm);
        }

        //Is Started metode
        public bool isStarted()
        {
            Console.WriteLine("\nMotor Slukket = False | Motor Started = True | \nMotorens tilstand er = " + Started);
            return Started;
        }

        //Start metode
        public bool Start()
        {
            if (Started == false)
            {
                Started = true;
                Rpm = 1000;
                Gear = 0;
            }
            else
            {
                Console.WriteLine("\nDin motor er allerede kørende");
            }
            return Started;
        }

        //Stop metode
        public bool Stop()
        {
            if (Started == true)
            {
                Started = false;
                Rpm = 0;
                Gear = 0;
            }
            else
            {
                Console.WriteLine("\nDin motor er allerede slukket");
            }
            return Started;
        }

        //GetSpeed metode
        public int GetSpeed()
        {
            Hastighed = (Rpm * Gear) / 200;

            return Hastighed;
        }

        //Gear op metode
        public int ShiftGearsUp()
        {
            if (Started == true && Gear < 5)
            {
                Gear++;
                Console.WriteLine("Der bliver gearet 1 gear op");
                Console.WriteLine("Bilen er i gear = " + Gear + " Gear");
            }
            return Gear;
        }

        //Gear ned metode
        public int ShiftGearsDown(int g)
        {
            if (Gear > g)
            {
                Console.WriteLine("Bilen er i gear = " + Gear + " Gear");
                Gear = 1;
                Console.WriteLine("Der bliver gearet ned til " + Gear + " Gear");
                //Console.WriteLine("Bilen er i gear = " + Gear + " Gear");
            }
            return Gear;
        }

        //Få det aktuelle gear
        public int GetGear()
        {
            Console.WriteLine($"Aktuelle gear : {Gear}");
            return Gear;
        }

        //Udskriv alle informationer
        public override string ToString()
        {
            return $"Motoren er = {Started}" + $"\nRpm = {Rpm}" + $"\nGear = {Gear}" + $"\nNavn = {Name}" + $"\nHastighed er = {Hastighed} Kmh";
        }
    }
}
