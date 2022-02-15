using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
    public class Model
    {
        private Engine _engine;
        private double _maxSpeed;
        private double _distance;
        private double _fuelСonsumption;
        public Model(ICarFactory factory)
        {
           _engine = factory.Speed();
           _maxSpeed = factory.MaxCarSpeed();
           _fuelСonsumption = factory.Fuelconsumption();
        }

        public void FuelСonsumption()
        {
            Console.WriteLine($"Machine used fuel:{_distance / _fuelСonsumption} liters");
            _engine.FuelСonsumption(_fuelСonsumption, _distance);
        }

        public void DistanceTraveled()
        {
            Console.WriteLine($"Distance traveled in 1 hour: {_maxSpeed * 1}km");
            _distance = _engine.DistanceЕraveled(_maxSpeed, 1);
        }
    }
}
