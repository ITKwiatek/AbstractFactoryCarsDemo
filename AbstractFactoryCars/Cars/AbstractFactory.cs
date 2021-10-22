using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars
{
    abstract class AbstractFactory
    {
        public abstract Car CreateFamilyCar();
        public abstract Car CreateRaceCar();
        public abstract Car CreateCityCar();
    }
}
