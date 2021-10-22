using AbstractFactoryCars.Cars.Toyota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars
{
    class ToyotaFactory : AbstractFactory
    {
        public override Car CreateCityCar()
        {
            return new Yaris();
        }

        public override Car CreateFamilyCar()
        {
            return new Proace();
        }

        public override Car CreateRaceCar()
        {
            return new Supra();
        }
    }
}
