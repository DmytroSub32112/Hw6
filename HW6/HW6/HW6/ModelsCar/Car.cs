using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
    public class Car : IComparable, ICarFactory
    {
        public int FuelСonsumption;
        public string Model;
        public bool Sport;
        public string Type;
        public int MaxSpeed;
        public int Coast;

        public int CompareTo(object obj)
        {
            var secondItem = obj as Car;
            if (secondItem == null)
            {
                throw new ArgumentException();
            }

            if (FuelСonsumption < secondItem.FuelСonsumption)
            {
                return -1;
            }

            if (FuelСonsumption > secondItem.FuelСonsumption)
            {
                return +1;
            }

            return 0;
        }

        public virtual double Fuelconsumption()
        {
            return FuelСonsumption;
        }

        public virtual int MaxCarSpeed()
        {
            return MaxSpeed;
        }

        public virtual Engine Speed()
        {
            return new Engine();
        }
    }
}
