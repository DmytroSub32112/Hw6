using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
    public class Engine : IEngine
    {
        public double DistanceЕraveled(double maxSped, int time)
        {
            return maxSped * time;
        }

        public double FuelСonsumption(double fuelConsumption, double distanceTraveled)
        {
            return distanceTraveled / fuelConsumption;
        }
    }
}
