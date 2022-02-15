using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.CarFactory
{
    public class Toksopark
    {
        public Car[] Cars = new Car[] { new BMWX3(), new Lada(), new SC20() };
        public void Sort()
        {
            var coastToksopark = 0;
            var i = 0;
            Array.Sort(Cars);
            foreach (var item in Cars)
            {
                i++;
                Console.WriteLine($"{i})FuelСonsumption: {item.FuelСonsumption},Model: {item.Model},Type: {item.Type},Sport car = {item.Sport},Caast = {item.Coast}$");
                coastToksopark += item.Coast;
            }

            Console.WriteLine($"The cost of all cars: {coastToksopark}$");
        }

        public Car ChoiseCar(string car)
        {
            var car1 = new Car();
            foreach (var item in Cars)
            {
                if (car == item.Model)
                {
                    car1 = item;
                }
            }

            Console.WriteLine($"FuelСonsumption: {car1.FuelСonsumption},Model: {car1.Model},Type: {car1.Type},Sport car = {car1.Sport},Caast = {car1.Coast}$");

            return car1;
        }
    }
}
