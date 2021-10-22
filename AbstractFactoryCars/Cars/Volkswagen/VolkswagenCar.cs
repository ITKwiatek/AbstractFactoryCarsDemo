using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars.Cars.Volkswagen
{
    abstract class VolkswagenCar : Car
    {
        public VolkswagenCar()
        {
            FactoryName = "Volkswagen";
        }
    }
}
