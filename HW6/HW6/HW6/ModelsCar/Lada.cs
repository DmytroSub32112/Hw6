using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
   public class Lada : SportCar
    {
        public Lada()
        {
            FuelСonsumption = 7;
            Model = "Lada Kalina";
            Type = "Sedan";
            Sport = false;
            MaxSpeed = 60;
            Coast = 500;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FuelСonsumption},{Model},{Type},{Sport}");
        }

        public override Engine Speed()
        {
            return new Engine();
        }

        public override int MaxCarSpeed()
        {
            return MaxSpeed;
        }

        public override double Fuelconsumption()
        {
            return FuelСonsumption;
        }
    }
}
