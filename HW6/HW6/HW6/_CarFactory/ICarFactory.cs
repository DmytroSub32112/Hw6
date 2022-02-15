using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
    public interface ICarFactory
    {
        public abstract int MaxCarSpeed();
        public abstract Engine Speed();
        public abstract double Fuelconsumption();
    }
}
