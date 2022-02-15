using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
    public static class Starter
    {
        public static void Run()
        {
            var toksopark = new Toksopark();
            toksopark.Sort();
            Console.WriteLine("User selected Lada Kalina");
            toksopark.ChoiseCar("Lada Kalina");
            var model = new Model(new Lada());
            model.DistanceTraveled();
            model.FuelСonsumption();
        }
    }
}
