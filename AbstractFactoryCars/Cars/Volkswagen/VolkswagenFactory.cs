using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryCars.Cars;
using AbstractFactoryCars.Cars.Volkswagen;

namespace AbstractFactoryCars
{
    class VolkswagenFactory : AbstractFactory
    {
        public override Car CreateCityCar()
        {
            return new Polo();
        }

        public override Car CreateFamilyCar()
        {
            return new T4();
        }

        public override Car CreateRaceCar()
        {
            return new Scirocco();
        }
    }
}
