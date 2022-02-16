using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
   public class BMWX3 : SportCar
   {
        public BMWX3()
        {
            FuelСonsumption = 13;
            Model = "BMW X3";
            Type = "Crossover";
            Sport = false;
            MaxSpeed = 160;
            Coast = 50000;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FuelСonsumption},{Model},{Type},{Sport}");
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
