using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
    public interface IEngine
    {
        public double DistanceЕraveled(double maxSped, int time);
        public double FuelСonsumption(double fuelConsumption, double distanceЕraveled);
    }
}
