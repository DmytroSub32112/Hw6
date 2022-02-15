using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
    public class SC20 : SportCar
    {
        public SC20()
        {
            FuelСonsumption = 17;
            Model = "Lamborgini sc20";
            Type = "Sedan";
            Sport = true;
            MaxSpeed = 200;
            Coast = 1000000;
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
