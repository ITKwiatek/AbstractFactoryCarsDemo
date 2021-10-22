using AbstractFactoryCars.Cars.Toyota;
using System;
using System.Collections.Generic;

namespace AbstractFactoryCars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractFactory> factories = new List<AbstractFactory>()
            {
                new ToyotaFactory(),
                new VolkswagenFactory()
            };
            List<Car> myCars = new List<Car>();
            foreach(var fact in factories)
            {
                myCars.Add(fact.CreateCityCar());
                myCars.Add(fact.CreateFamilyCar());
                myCars.Add(fact.CreateRaceCar());
            }
            foreach(var car in myCars)
            {
                car.Describe();
            }

            foreach(var car in myCars)
            {
                if (car is ToyotaCar)
                {
                    Console.WriteLine("Toyota car in the list");
                }
            }

        }
    }
}
