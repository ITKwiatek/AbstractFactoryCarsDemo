using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars.Cars.Toyota
{
    public abstract class ToyotaCar : Car
    {
        public ToyotaCar()
        {
            FactoryName = "Toyota";
        }
    }
}
